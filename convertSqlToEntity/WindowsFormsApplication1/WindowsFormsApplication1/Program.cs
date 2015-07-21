using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication1.form;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string file = @"E:\222.txt";

//            //创建并写入（将覆盖已有的文件）
//            if (!File.Exists(file))
//            {
//                using (StreamWriter sw = File.CreateText(file))
//                {
//                    sw.WriteLine("Hello2!");
//                }
//            }
//
//            //读取文件
//            using (StreamReader sr = File.OpenText(file))
//            {
//                string s = "";
//                while ((s = sr.ReadLine()) != null)
//                {
//                    Console.WriteLine(s);
//                }
//            }
//
//            //删除或拷贝
//            try
//            {
//                File.Copy(file, @"E:\11222.txt");
//                File.Delete(file);
//
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("错误啦！", "系统提示");
//                return;
//            }
            decimal a = new decimal(1.1);
            decimal b = new decimal(2.2);
            Console.WriteLine(((a + b) / 10 * b).ToString("0%"));
            Console.WriteLine((1.0/2.0).ToString("0%"));
            Console.WriteLine((1.1/12.0).ToString("P"));
            Console.ReadLine();
        }
    }
}
