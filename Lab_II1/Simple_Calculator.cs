using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_II1
{
    public class Simple_Calculator
    {
        private int num1;
        private int num2;
        public Simple_Calculator(int num1,int num2) {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int Sum() {
            return num1 + num2;
        }
        public int Div() { 
            return num1 / num2;
        }
        public int Mul() { 
            return (num1 * num2);
        }
        public int Dif() {
            return num1 - num2;
        }
        public void Show(char oper,int result) {
            Console.WriteLine( Convert.ToString(num1) + oper + Convert.ToString(num2) + " = "+result);
        }
    }
}
