
using Lab_II1;

internal class Program
{
  
    private static void Main(string[] args)
    {
        //Lab1_ex5
        float number, product=1f,sum=0f;
        Console.WriteLine("Insert number of elements:");
        int length = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= length; i++) {
            Console.WriteLine("Inser number :");
            number = Convert.ToSingle(Console.ReadLine());
            product=product*number;
            sum=sum+number; 
        }
        float media_A = sum / length;
        float media_G = (float)Math.Pow(product, 1.0/length);
        Console.WriteLine("Media Aritmetica = "+media_A+" and Media Geometrica= "+media_G);

        //Lab1_ex1
        int Fn;
        int F0 = 0; int F1 = 1;
        Console.WriteLine("Insert number of Fibonacci elements :");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(F0 + " " + F1 + " ");
        for (int i = 2; i < n; i++)
        {

            Fn = F0 + F1;
            F0 = F1;
            F1 = Fn;
            Console.Write(Fn + " ");
        }
        Console.WriteLine("\n");
        
        // Lab1_ex3
        ConversionTemp obj = new();
        Console.WriteLine("Insert temperature");
        int temp = obj.ReadTemp();
        obj.ConvertToF(temp);
        obj.ConvertToC(temp);
        
        // Lab1_ex4
        Console.WriteLine("Calculate Ideal Weight (not accurate)");
        Console.WriteLine("Insert gender [either F or M]");
        char gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Insert age [years]");
        float age=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Insert height [cm]");
        float height=Convert.ToSingle(Console.ReadLine()); ;
        Weight_ideal person = new Weight_ideal(age,height,gender);
        person.Show();
        Console.WriteLine("\n");
       
        
        // Lab1_ex2
        Console.WriteLine("Insert first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert Operator ");
        char oper = (char)Console.Read();
        Simple_Calculator calc1 = new Simple_Calculator(num1, num2);

        switch (oper)
        {

            case '+':
                calc1.Show(oper, calc1.Sum());
                break;
            case '-':
                calc1.Show(oper, calc1.Dif());
                break;
            case '*':
                calc1.Show(oper, calc1.Mul());
                break;
            case '/':
                calc1.Show(oper, calc1.Div());
                break;
            default:
                Console.WriteLine("Operator not found");
                break;
        }
      
    }
  
}



