using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {

            //ForLoop1();

            //ForLoop2();

            //WhileLoop();

            //DoWhileLoop();

            //ForeachLoop();


            int number = 6;

            MyPrimeNumber(number);


            Console.WriteLine("*******Other Way******");


            if (IsPrimeNumber(number))
            {
                Console.WriteLine("This is a prime number.");

            }
            else
            {
                Console.WriteLine("This is not a prime number.");
                
            }

            Console.ReadLine();

        }




        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i <= number-1; i++)
            {
               

                if (number % i == 0)
                {
                    result = false;
                    i = number;
                   
                }

                
            }

            return result;

           



        }





        private static void  MyPrimeNumber(int number)
        {
            int a = 0;

            for (int i = 2; i < number; i++)
            {
               

                if (number % i == 0)
                {
                    a++;
                    break;
                } 
            }

            if (a == 0)
            {

                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + "  is not a prime number.");
            }

      
        
        
        }



        private static void ForLoop1()
        {

            


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished1");


            

        }



        private static void ForLoop2()
        {

            for (int i = 10; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
           


            Console.WriteLine("Finished2");

        }



        private static void WhileLoop()
        {
            int number = 10;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Finished3");
            Console.WriteLine("Now number is {0}", number);

          
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number >= 0);

            Console.WriteLine("Finished4");

           
        }



        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
         
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Finished5");
            
        }




    }
}

