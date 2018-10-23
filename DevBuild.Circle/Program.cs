using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBuild.Utilities;

namespace DevBuild.Circle
{
    class Program { 
        static void Main(string[] args)
        {
            string userResponse; 
            double userRadius = 0;
            Circle userCircle;

            while (true)
            {
                userResponse = "";
                Console.WriteLine("Welcome to the Circle Tester  ");

                while (!double.TryParse(userResponse, out userRadius) || userRadius < 0) {
                    UserInput.PromptUntilValidEntry("Enter radius: ", out userResponse, InformationType.Numeric);
                }
                userCircle = new Circle(userRadius);
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("********************************");
                Console.WriteLine($"Circumference (2\x3C0r): {userCircle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area (\x3C0r\x00B2): {userCircle.CalculateFormattedArea()}");
                Console.WriteLine("********************************");
            }
        }
    }
}
