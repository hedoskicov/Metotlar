using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();  
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1 ;
            person1.FirstName = "Derin";
            
            Console.WriteLine(person1.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12151420";
            Person person3 = customer;

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            PersonManager personmanager = new PersonManager();
            Console.WriteLine("yeni yer");
            personmanager.Add(employee);


        }
    }
    
    class Person
    {
        public int Id { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // base class : Person 
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; } 
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
