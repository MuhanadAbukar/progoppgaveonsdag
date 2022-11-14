using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp5
{
    internal class Program
    {
        static int len(int num)
        {
            int len = 0;
            for (int i = 1; i < num; i *= 10)
            {
                len++;
            }
            return len;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            len(num);
        }
        
    }
}
