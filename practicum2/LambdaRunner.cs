using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();
            Person p = new Person();
            // methode TimesThree herschreven als lambda-expressie
            Func<int, int> TimesThree = x => 3 * x;
            output.AppendFormat("TimesThree({0}) = {1}\n", num1, TimesThree(num1));
            Func<int, int, int, int> AddNumbers = (x, y, z) => x + y + z;
            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", num1, num2, num3, AddNumbers(num1, num2, num3));
            Func<int, bool> isEven = x => x %2 == 0;
            output.AppendFormat("IsEven({0}) = {1}\n", num1, Methods.IsEven(num1));
            Func<int, string> Num2String = x =>
            {
                switch (x)
                {
                    case 0:
                        return "zero";
                        
                    case 1:
                        return "one";
                        
                    case 2:
                        return "two";
                        
                    case 3:
                        return "three";
                        
                    case 4:
                        return "four";
                        
                    case 5:
                        return "five";
                        
                    case 6:
                        return "six";
                        
                    case 7:
                        return "seven";
                        
                    case 8:
                        return "eight";
                        
                    case 9:
                        return "nine";
                        
                    default:
                        return "undefined";
                      
                }
            };
            output.AppendFormat("Num2String({0}) = {1}\n", num1, Num2String(num1));


            Func<int, int, int, bool> InBetween = (x, y, z) => x < y && y < z;
            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", num1, num2, num3, InBetween(num1, num2, num3));
          
            
            Action<Person> ResetName = x => p.Name = null;
            ResetName(p);
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n", p.Name == null);


     




           
            

            //aanvullen

            return output.ToString();
        }

    }
}
