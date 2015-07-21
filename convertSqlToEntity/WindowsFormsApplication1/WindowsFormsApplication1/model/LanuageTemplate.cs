using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.model
{
    class LanuageTemplate : ICloneable
    {
        private int language_type;//语言类型

        public int Language_type
        {
            get { return language_type; }
            set { language_type = value; }
        }
        private string class_template_path;//类模板路径

        public string Class_template_path
        {
            get { return class_template_path; }
            set { class_template_path = value; }
        }
        private string field_template_path;//字段模板路径

        public string Field_template_path
        {
            get { return field_template_path; }
            set { field_template_path = value; }
        }
        private string field_type_map_path;//sql对语言字段映射的路径

        public string Field_type_map_path
        {
            get { return field_type_map_path; }
            set { field_type_map_path = value; }
        }
        private string method_template_path;//方法模板的路径

        public string Method_template_path
        {
            get { return method_template_path; }
            set { method_template_path = value; }
        }
        private string target_file_type;//生成文件类型

        public string Target_file_type
        {
            get { return target_file_type; }
            set { target_file_type = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone(); //浅复制
        }

    }
}
