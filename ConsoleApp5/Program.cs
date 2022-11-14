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
        static int len(int num, int rec)
        {
            if (num == 0)
                return rec;
            num /= 10;
            rec++;
            return len(num, rec);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(len(num,0));
            Console.ReadLine();
        }
        
    }
}
