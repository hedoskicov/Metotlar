﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara"};
            Customer customer2 = new Customer( 2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }
        // default constructor - (parametresi olmayan constructor)
        public Customer() // ( parametre alır ) 
        {
            Console.WriteLine("Yapıcı Blok Çalışır");
        }
        public int Id { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
