using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MakeWebPage(10);
        }

        static void MakeWebPage(int n)
        {
            StreamWriter fileStream = new StreamWriter(@"C:\Users\oraha\Desktop\new website\webf.html");
            string[] color = { "blue", "green", "red" };
            fileStream.WriteLine("<html>\n <body>\n \t <div style=\"width:100%; height:100%;\">");
            for(int i = 0; i < n; i++)
            {           
                fileStream.WriteLine("\t \t <div style=\"width: "+ 100 / n +"%; height: 100%; background-color: " + color[i%3] + "; float: left\"></div>");  
            }
            fileStream.WriteLine("\t </div>\n </body> \n </html>");
            fileStream.Close();
        }
    }
}
