using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Intro();

            //String ile kullanılan metotlar:

            string sentence = "My name is Engin Demirog";

            var result = sentence.Length; 
            Console.WriteLine(result);


            var result2 = sentence.Clone(); 
                                            
            sentence = "My name is Derin Demirog"; 
            Console.WriteLine(result2);


            bool result3 = sentence.EndsWith("g"); 
            Console.WriteLine(result3);

            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("name"); 
            Console.WriteLine(result5);                                 
            
            var result6 = sentence.IndexOf(" "); 
            Console.WriteLine(result6);

            var result7 = sentence.LastIndexOf(" "); 
            Console.WriteLine(result7);

            var result8 = sentence.Insert(0, "Hello, "); 
            Console.WriteLine(result8);

            var result9 = sentence.Substring(3);  
            Console.WriteLine(result9);          

            var result99 = sentence.Substring(3,4); 
            Console.WriteLine(result99);            

            var result10= sentence.ToLower(); 
            Console.WriteLine(result10);                                           

            var result11= sentence.ToUpper(); 
            Console.WriteLine(result11);

            var result12 = sentence.Replace(" ", "-");  
            Console.WriteLine(result12);
            
            var result13= sentence.Remove(2);
            Console.WriteLine(result13);


            var result133 = sentence.Remove(2,5); 
            Console.WriteLine(result133);




            Console.ReadLine();

        }

        public static void Intro()
        {



            string city = "Ankara";
            
            // Console.WriteLine(city[0]);


            foreach (char item in city)
            {
                Console.WriteLine(item);
            }



            string city2 = "İstanbul";

            // string result= city + city2;  Console.WriteLine(result); 

            Console.WriteLine(String.Format("{0} {1}", city, city2));  




           
        }


    }
}
