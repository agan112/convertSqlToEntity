using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.util
{
    public class CommonUtil
    {
        //数据库字段类型，java字段类型
        public static Dictionary<string, string> javaFieldTypeMap = new Dictionary<string, string>() 
        {
             {"NUMBER","long"},
             {"VARCHAR2","String"},
             {"VARCHAR","String"},
             {"DATE","Timestamp"}
        };

        //数据库字段类型，c#字段类型
        public static Dictionary<string, string> cSharpFieldTypeMap = new Dictionary<string, string>() 
        {
             {"NUMBER","long"},
             {"VARCHAR2","string"},
             {"VARCHAR","string"},
             {"DATE","DateTime"}
        };

        /// <summary>
        /// 转换第一个字母大写
        /// </summary>
        /// <param name="code">字符串</param>
        /// <returns>第一个字母大写的字符串</returns>
        public static string ToUpperFirstCode(string code)
        {
            char[] strChar = code.ToCharArray();
            strChar[0] = Convert.ToChar(strChar[0].ToString().ToUpper());
            string strCode = "";
            for (int i = 0; i < strChar.Length; i++)
            {
                strCode += strChar[i];
            }
            return strCode;
        }
    }
}
