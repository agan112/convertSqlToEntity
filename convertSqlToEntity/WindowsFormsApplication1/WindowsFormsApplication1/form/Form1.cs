using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication1.form;
using System.Collections;
using WindowsFormsApplication1.model;
using WindowsFormsApplication1.util;
namespace WindowsFormsApplication1.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path="";
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //选择文件
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Filter = "sql文件 | *.sql";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] picArr;//选择多张图片路径保存到数组
                picArr = openFileDialog1.FileNames;
                if (picArr != null && picArr.Length > 0)
                {
                    //展示配置类名的控件
                    ConfigForm form = new ConfigForm();
                    for (int i = 0; i < picArr.Length; i++)
                    {
                        string[] row = { picArr[i] };
                        form.dataGridView1.Rows.Add(row);
                    }
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        path=GetCurrentPath();
                        string defaultTargetFile = @path + @"\tempData";
                        for (int i = 0; i < form.dataGridView1.Rows.Count; i++)
                        {
                            if (form.dataGridView1.Rows[i].Cells["filePath"].Value == null)
                                continue;
                            string filePath = form.dataGridView1.Rows[i].Cells["filePath"].Value.ToString();
                            string classPath = form.dataGridView1.Rows[i].Cells["classPath"].Value.ToString();
                            string className = form.dataGridView1.Rows[i].Cells["className"].Value.ToString();

                            if (!string.IsNullOrEmpty(filePath))
                            {
                                //生成文件
                                creatFile(filePath, classPath, className, defaultTargetFile);
                            }
                        }
                        //打开生成文件的位置
                        openTargetFile(defaultTargetFile);
                    }
                }
            }

        }

        //打开文件
        private void openTargetFile(string defaultTargetFile)
        {
            if (!string.IsNullOrEmpty(defaultTargetFile))
            {
                System.Diagnostics.Process.Start(defaultTargetFile);
            }
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="sqlPath">sql文件的路径</param>
        /// <param name="classPath">生成文件类路径</param>
        /// <param name="className">生成文件的类名称</param>
        /// <param name="targetFile">生成目标文件的路径</param>
        private void creatFile(string sqlPath, string classPath, string className, string targetFile)
        {
            //获取所有的语言配置

            //根据既定的规则创建不同的语言对象，生成不同的文件

            StringBuilder fieldBuilder = new StringBuilder();
            StringBuilder methodBuilder = new StringBuilder();
            StringBuilder contextBuilder = new StringBuilder();
            try
            {
                List<LanuageTemplate> templateList = getTemplateList();

                //批量创建文件
                foreach (LanuageTemplate lan in templateList)
                {
                    fieldBuilder.Clear();
                    methodBuilder.Clear();
                    contextBuilder.Clear();

                    StreamReader contextReader = new StreamReader(lan.Class_template_path, Encoding.UTF8);
                    string contextLine ;
                    while ((contextLine = contextReader.ReadLine()) != null)
                    {
                        int index = contextLine.IndexOf("%class_context%");
                        if (index != -1)
                        {
                            //                        contextLine.
                            create(lan,sqlPath, 10, fieldBuilder, methodBuilder);
                            contextBuilder.Append(fieldBuilder).Append("\r\n");
                            contextBuilder.Append(methodBuilder).Append("\r\n");
                        }
                        else if (contextLine.IndexOf("%class_path%") != -1)
                        {
                            contextLine = findAndReplace(contextLine, "%class_path%", classPath);
                            contextBuilder.Append(contextLine).Append("\r\n");
                        }
                        else if (contextLine.IndexOf("%class_name%") != -1)
                        {
                            contextLine = findAndReplace(contextLine, "%class_name%", className);
                            contextBuilder.Append(contextLine).Append("\r\n");
                        }
                        else
                        {
                            contextBuilder.Append(contextLine).Append("\r\n");
                        }
                    }
                    contextReader.Close();

                    StreamWriter writer = new StreamWriter(targetFile + "\\" + className+lan.Target_file_type, false);
                    writer.Write(contextBuilder);
                    writer.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
                return;
            }
        }

        private List<LanuageTemplate> getTemplateList()
        {
            List<LanuageTemplate> templateList = new List<LanuageTemplate>();
            LanuageTemplate java_lan = new LanuageTemplate();
            java_lan.Language_type = 1;
            java_lan.Field_template_path = @path+@"\config\java_field_template.txt";
            java_lan.Class_template_path = @path + @"\config\java_class_template.txt";
            java_lan.Field_type_map_path = @path + @"\config\java_field_type_map.txt";
            java_lan.Method_template_path = @path + @"\config\java_method_template.txt";
            java_lan.Target_file_type = ".java";
            templateList.Add(java_lan);

            LanuageTemplate csLan = new LanuageTemplate();
            csLan.Language_type = 2;
            csLan.Field_template_path = @path + @"\config\c#_field_template.txt";
            csLan.Class_template_path = @path + @"\config\c#_class_template.txt";
            csLan.Method_template_path = @path + @"\config\c#_method_template.txt";
            csLan.Target_file_type = ".cs";
            templateList.Add(csLan);

            return templateList;
        }
        private static void create(LanuageTemplate lan,string sqlFile,int index, StringBuilder fieldBuilder, StringBuilder methodBuilder)
        {

            //parsh the sql file
            StreamReader sqlReader = new StreamReader(sqlFile, Encoding.UTF8);
            Dictionary<string, Hashtable> dicField = createSqlTemplate(sqlReader);


            string fieldPath = lan.Field_template_path;
            string methodPath = lan.Method_template_path;
            StreamReader fieldReader = new StreamReader(fieldPath, Encoding.UTF8);
            StreamReader methodReader = new StreamReader(methodPath, Encoding.UTF8);
            //遍历所有的表进行生成相应的配置

            foreach (Hashtable table in dicField.Values)
            {
                string []fieldArr=new string[table.Keys.Count];
                int i=0;
                foreach(string key in table.Keys)
                {
                    fieldArr[i++]=key;
                }
                Array.Sort(fieldArr);

                foreach (string key in fieldArr)
                {
                    ClassTemplate meta = (ClassTemplate)table[key];
                    ClassTemplate newMeta = (ClassTemplate)meta.Clone();
                    newMeta.Field_type = getFieldType(newMeta, lan.Language_type);
                    convertToField(index, fieldBuilder, fieldReader, newMeta, lan.Language_type);
                    convertToMethod(index, methodBuilder, methodReader, newMeta);
                }
            }
            sqlReader.Close();
            fieldReader.Close();
            methodReader.Close();
        }

        private static Dictionary<string, Hashtable> createSqlTemplate(StreamReader sqlReader)
        {
            if (sqlReader == null)
                return null;
            string line;
            Dictionary<string, Hashtable> dic = new Dictionary<string, Hashtable>();
            bool followTable = false;
            string newTableName = "";
            ClassTemplate preFieldClass = null;//前一个字段的对象
            try
            {
                while ((line = sqlReader.ReadLine()) != null)
                {
                    if (line.StartsWith("--"))
                        continue;

                    string[] tempArr = line.Split(' ');
                    if (tempArr.Length == 0)
                        return null;
                    List<string> fieldList = new List<string>();

                    //遍历数组只有有数据的时候才算有效的
                    foreach (string str in tempArr)
                    {
                        if (string.IsNullOrEmpty(str))
                            continue;
                        fieldList.Add(str);
                    }
                    if (fieldList.Count > 1)
                    {
                        if ("create".Equals(fieldList[0], StringComparison.OrdinalIgnoreCase) && "table".Equals(fieldList[1], StringComparison.OrdinalIgnoreCase))
                        {
                            //添加表名 
                            newTableName = fieldList[2];
                            dic.Add(newTableName, new Hashtable());
                            followTable = true;
                            continue;
                        }
                        if (followTable)
                        {


                            Hashtable table = dic[newTableName];
                            //字段,类型
                            ClassTemplate temp = new ClassTemplate();
                            temp.Field_name = fieldList[0].ToLower();
                            temp.Field_type = fieldList[1];
                            table.Add(fieldList[0].ToLower(), temp);
                        }
                    }
                    if (line.IndexOf(")") != -1 && line.IndexOf(";") != -1)
                    {
                        //创建表名结束
                        followTable = false;
                        continue;
                    }

                    if (!followTable)
                    {
                        //创建注释
                        if (fieldList.Count > 3)
                        {
                            if ("comment".Equals(fieldList[0], StringComparison.OrdinalIgnoreCase)
                                && "on".Equals(fieldList[1], StringComparison.OrdinalIgnoreCase)
                                && "column".Equals(fieldList[2], StringComparison.OrdinalIgnoreCase))
                            {

                                string[] fieldStr = fieldList[3].Split('.');
                                if (fieldStr.Length == 2)
                                {
                                    Hashtable table = dic[newTableName];
                                    object obj = table[fieldStr[1].ToLower()];
                                    if (obj != null)
                                    {
                                        preFieldClass = obj as ClassTemplate;
                                        continue;
                                    }
                                }
                            }
                        }

                        //注释紧跟在is的后面
                        if (preFieldClass != null)
                        {
                            if (fieldList[0].IndexOf("is") != -1)
                            {

                                preFieldClass.Annotation = fieldList[1].Replace("'", "").Replace(";","");
                                preFieldClass = null;
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("解析失败！" + ex.Message, "系统");
                return null;
            }

            return dic;
        }

        private static void convertToMethod(int spaceCount, StringBuilder methodBuilder, StreamReader reader, ClassTemplate meta)
        {
            if (methodBuilder == null || reader == null || meta == null)
                return;

            //文件流回到开始的位置
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            reader.BaseStream.Position = 0;

            string line = reader.ReadLine();
            while (line != null)
            {
                line = findAndReplace(line, "%field_type%", meta.Field_type);
                line = findAndReplace(line, "%field_name%", meta.Field_name);
                line = findAndReplace(line, "%Field_name%", meta.Upper_field_name);
                methodBuilder.Append(getDesignatedSpace(spaceCount)).Append(line).Append("\r\n");
                line = reader.ReadLine();
            }

        }

        private static void convertToField(int spaceCount, StringBuilder fieldBuilder, StreamReader reader, ClassTemplate meta, int language_type)
        {
            if (fieldBuilder == null || reader == null || meta == null)
                return;
            //文件流回到开始的位置
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            reader.BaseStream.Position = 0;

            string line;
            while ((line = reader.ReadLine()) != null)
            {

                line = findAndReplace(line, "%field_type%", meta.Field_type);
                line = findAndReplace(line, "%field_name%", meta.Field_name);
                line = findAndReplace(line, "%Field_name%", meta.Upper_field_name);
                if (line.IndexOf("%annotation%")!=-1&&string.IsNullOrEmpty(meta.Annotation))
                {
                    continue;
                }
                line = findAndReplace(line, "%annotation%", meta.Annotation);
                fieldBuilder.Append(getDesignatedSpace(spaceCount)).Append(line).Append("\r\n");
                
            }
        }

        private static string getFieldType(ClassTemplate meta, int language_type)
        {

            if (language_type == 1)
            {
                if (meta.Field_name.ToUpper().IndexOf("AMOUNT") != -1)
                {
                    //以amount结尾
                    return "BigDecimal";
                }
                foreach (string str in CommonUtil.javaFieldTypeMap.Keys)
                {
                    if (meta.Field_type.ToUpper().IndexOf(str) != -1)
                    {
                        return CommonUtil.javaFieldTypeMap[str];

                    }
                }
            }
            else if (language_type == 2)
            {
                if (meta.Field_name.ToUpper().LastIndexOf("AMOUNT") != -1)
                {
                    //以amount结尾
                    return "decimal";
                }
                foreach (string str in CommonUtil.cSharpFieldTypeMap.Keys)
                {
                    if (meta.Field_type.ToUpper().IndexOf(str) != -1)
                    {
                        return CommonUtil.cSharpFieldTypeMap[str];
                    }
                }
            }
            return "";
        }

        private static string getDesignatedSpace(int spaceCount)
        {
            return "".PadLeft(spaceCount);
        }

        private static string findAndReplace(string source, string findStr, string newStr)
        {
            if (source == null || findStr == null )
                return source;
            if (source.IndexOf(findStr) != -1)
            {
                source = source.Replace(findStr, newStr);
            }
            return source;
        }

        public static string GetCurrentPath()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string path = asm.Location.Remove(asm.Location.LastIndexOf("\\")) + "\\";
            return path;
        }

    }
}
