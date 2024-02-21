using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
           

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
             new SqlServerCustomerDal(),  
             new OracleCustomerDal(),     
             new MySqlServerCustomerDal(),
                                          

            };

            

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }


        private static void Demo()
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal()); 
            customerManager.Add(new OracleCustomerDal());  

            Console.ReadLine();


            IPerson person = new Customer();
            
        }




        private static void InterfacesIntro()

            {

                PersonManager personManager = new PersonManager();

                

                personManager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demirog", Address = "Ankara" });


                


                /* 

                Customer customer = new Customer()
                {
                  Id = 1, FirstName = "Engin", LastName = "Demirog", Address = "Ankara" 
                };
                personManager.Add(customer);

                */


                Student student = new Student()
                { Id = 2,
                    FirstName = "Derin",
                    LastName = "Demirog",
                    Departmant = "Computer Sciences" 
                };

                personManager.Add(student);

                


            }

            


        

    }

    interface IPerson
    {

        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
       
    }

    class Customer : IPerson
    {
     
        public int Id { get; set ; }
        public string FirstName { get;  set; }
        public string LastName { get ; set; }

        public string Address { get; set; }
    }



    class Student : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get; set ; }
        public string LastName { get; set ; }

        public string Departmant { get; set; }
    }



    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }




    class PersonManager
    {
        public void Add(IPerson _ıperson)
        {
            


            Console.WriteLine(_ıperson.FirstName);
        }

    }




}
