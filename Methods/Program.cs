﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    

    public class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();

            int result1 = Add2(20, 30);
            Console.WriteLine(result1);

            int result2 = Add2(20);
            Console.WriteLine(result2);


            int number1 = 20;
            int number2 = 100;
            var result3 = Add3(number1, number2);  

           


            Console.WriteLine(result3);
            Console.WriteLine(number1);


            var result4 = Add4(ref number1, number2);

            Console.WriteLine(result3);
            Console.WriteLine(number1);


            int number;

            
             
            var result5 = Add5(out number, number2);

            Console.WriteLine(result5);

            Console.WriteLine(number);



            Console.WriteLine(Multiply(2,4)); 



            Console.WriteLine(Multiply(2, 4, 5)); 



            Console.WriteLine(Add6(10,20,30,40,50)); 





            Console.ReadLine();

        }


        static void Add()
        {

            Console.WriteLine("Added.");
        
        }


        static int Add2(int number1, int number2=30)
        {
            int result = number1 + number2;
            return result;
            
        
        }




        static int Add3(int number1, int number2)
        {
           
            number1 = 30;
            return number1 + number2;
        }



        static int Add4(ref int number1, int number2)
        {
          
            number1 = 30;
            return number1 + number2;
        }



        static int Add5(out int number, int number2)
        {
            
            number = 30;
            return number + number2;

        }



        static int Multiply(int number1, int number2)
        {

            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {

            return number1 * number2 * number3;

        }


        static int Add6(int number1, params int[] numbers)
        {
            
            return numbers.Sum();

        }

    }
}
