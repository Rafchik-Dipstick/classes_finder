using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Text;

namespace WindowsFormsApp1
{


    public class Files
    {
        public string read()
        {
            FileStream fstream = File.OpenRead("1.txt");
            byte[] array = new byte[fstream.Length];
            fstream.Read(array, 0, array.Length);
            fstream.Close();
            string text = Encoding.Default.GetString(array);
            return text;
        }

        
            public void Write(string _s)
            {
                FileStream fs = new FileStream("1.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                StringBuilder output = new StringBuilder();
                output.Append(_s);
                writer.WriteLine(output.ToString());
                writer.Close();
            }
        
       

        public int Transform()
        {
            string s = read();
            int flag = 1;
         int final = 0;
            
            for (int i = 0;i < s.Length - 2; i ++ )
            {
               if(s[i] != s[i+1])
                {
                    
                    final += flag;
                }
               
            }
            return final;
        }
        
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

        ;
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
