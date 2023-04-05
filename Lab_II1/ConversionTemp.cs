using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_II1
{
    internal class ConversionTemp
    {
        public void ConvertToF(int temp)
        {
            Console.WriteLine("temp in F : " + (temp * 9 / 5 + 32));
        }
        public void ConvertToC(int temp)
        {
            Console.WriteLine("temp in C :" + ((temp - 32) * 5 / 9));
        }
        public int ReadTemp() {
            int temp = 0;
            temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }
    }
}
