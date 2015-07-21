using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.form
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.Red;
            dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.Red;
        }

        //下一步
        private void button1_Click(object sender, EventArgs e)
        {
            bool check = checkData();
            if(check)
                this.DialogResult = DialogResult.OK;
        }

        private bool checkData()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                object objFilePath = dataGridView1.Rows[i].Cells["filePath"].Value;
                object objClassPath = dataGridView1.Rows[i].Cells["classPath"].Value;
                object objClassName = dataGridView1.Rows[i].Cells["className"].Value;
                if (objFilePath == null || string.IsNullOrEmpty(objFilePath.ToString()))
                {
                    continue;
                    MessageBox.Show("第"+(i+1)+"行，"+dataGridView1.Columns[0].Name+"不能为空！","系统提示");
                    return false;
                }
                if (objClassPath == null || string.IsNullOrEmpty(objClassPath.ToString()))
                {
                    MessageBox.Show("第" + (i + 1) + "行，" + dataGridView1.Columns[1].Name + "不能为空！", "系统提示");
                    return false;
                }
                if (objClassName == null || string.IsNullOrEmpty(objClassName.ToString()))
                {
                    MessageBox.Show("第" + (i + 1) + "行，" + dataGridView1.Columns[2].Name + "不能为空！", "系统提示");
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
