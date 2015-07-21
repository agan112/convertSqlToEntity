using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.model
{
    class ClassTemplate : ICloneable
    {
        private string annotation;

        public string Annotation
        {
            get { return annotation; }
            set { annotation = value; }
        }
        private string field_type;

        public string Field_type
        {
            get
            {
                return field_type;
            }
            set
            {
                field_type = value;
            }
        }
        private string field_name;

        public string Field_name
        {
            get { return field_name; }
            set
            {
                field_name = value;
                upper_field_name = CommonUtil.ToUpperFirstCode(field_name);
            }
        }
        private string upper_field_name;

        public string Upper_field_name
        {
            get { return upper_field_name; }
        }

        public object Clone()
        {
            return this.MemberwiseClone(); //浅复制
        }

    }
}
