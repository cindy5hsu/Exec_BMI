using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXEC_BMI
{
    //計算BMI
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in KG: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine("Your BMI is: " + Math.Round(BMI, 2));
            Console.ReadKey();

           // string result = string.Empty;
            if (BMI < 16)
                // result = "severly underweight";
                Console.WriteLine("severly underweight");

            else if (BMI < 18.5)
                //result = "You're underweight";
                Console.WriteLine("You're underweight");
            else
                if (BMI < 25)
                //result = "You have normal weight";
            Console.WriteLine("You have normal weight");
            else if (BMI < 30)
                //result = "You're overweight ";
                Console.WriteLine("You're overweight ");
            else if (BMI < 35)
                //result = "You're moderately obese";
                Console.WriteLine("You're moderately obese");
            else //result = "You're serverly obese";
                Console.WriteLine("You're serverly obese");
        }

    }
}