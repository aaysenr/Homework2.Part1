using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 10;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            string city = "Ankara"; 
            double number5 = 10.4;
            decimal number6 = 10.4m;
            var number7 = 10;
            number7 = 'A'; 
            // number7 = "A"; 





            Console.WriteLine("Number1 is: {0}", number1);
            Console.WriteLine("Number2 is: {0}", number2);
            Console.WriteLine("Number3 is: {0}", number3);
            Console.WriteLine("Number4 is: {0}", number4);
            Console.WriteLine("Condition is: {0}", condition);
            Console.WriteLine("Character is: {0}", character);
            Console.WriteLine("Character Changes To İnt: {0}", (int)character); 
            Console.WriteLine("City is: {0}", city);
            Console.WriteLine("Number5 is: {0}", number5);
            Console.WriteLine("Number7 is: {0}", number7);

            Console.WriteLine(Days.Friday);

            Console.WriteLine((int)Days.Friday);


            Console.WriteLine((int)Days1.Friday);

            Console.WriteLine((int)Days2.Friday);

            Console.WriteLine((int)Days2.Wednesday);

            Console.WriteLine((int)Days2.Sunday);


            Console.WriteLine("Number1 is: {0}, Number2 is: {1} , Number3 is: {2} , Number4 is: {3} ,Number5 is: {4}, Number6 is {5}, Number7 is {6}", number1, number2, number3, number4, number5, number6, number7);






            Console.ReadLine();



            // eğer string kullanılsaydı karşılaştırmalarda:

            /* if("Friday")
               {

               }

            */


            //eğer enum kullanılırsa bu karşılaştırma:


            /* if(Days.Friday== )
              {

              }
              
             */

        }
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        enum Days1
        {
            Monday =10 , Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        enum Days2
        {
            Monday=23, Tuesday=34, Wednesday=45, Thursday=56, Friday, Saturday=67, Sunday
        }
    }
}
    
