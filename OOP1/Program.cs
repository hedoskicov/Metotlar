﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 3;
            product1.UnitsInStock = 5;

            Product product2 = new Product {Id = 2, CategoryId= 3, ProductName = "Kalem", UnitPrice = 5, UnitsInStock = 3};  
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
        }
    }
}
