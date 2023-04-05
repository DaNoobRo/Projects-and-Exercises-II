using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_II1
{
    internal class Weight_ideal
    {
        private readonly float age;
        private readonly float height;
        private readonly char gender;

        public Weight_ideal(float age, float height,char gender) { 
            this.age = age;
            this.height = height;
            this.gender = gender;   
        }
        public float Calculate() {

            float ideal = 0;
            if (gender == 'F')
            {
                ideal = height - 100f - ((height - 150) / 2.5f) + ((age - 20) / 6f);
            }
            else if (gender == 'M')
            {
                ideal = height - 100f - ((height - 150) / 4f) + ((age - 20) / 4f);
            }
            else { Console.WriteLine("Gender not in database"); }
            return ideal;
        }
        public void Show() {
            if (gender == 'F')
            {
                Console.WriteLine(height + "[cm] - 100 - ((" + height + "- 150) / 2.5) + (("+ age + "[years] - 20) / 6))="+this.Calculate());
            }
            else 
            {
                Console.WriteLine(height + "[cm] - 100 - ((" + height + "- 150) / 4) + ((" + age + "[years] - 20) / 4))=" + this.Calculate());
            }
        }
    }
}
