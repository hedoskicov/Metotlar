using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<float,int> products = new MyDictionary<float,int>();
            products.Add(1, 35);
            products.Add(2, 50);
            products.Add(3, 90);
            products.Add(4, 105);
            products.Add(5, 104);

            Console.WriteLine(products.CountId);

            Console.WriteLine(products.CountPrice);


            Console.WriteLine("Id numaraları");

            foreach (var productId in products.Ids)
            {
                Console.WriteLine(productId);
            }


            Console.WriteLine("ürünlerin fiyatları");

            foreach (var productPrice in products.Prices)
            {
                Console.WriteLine(productPrice);
            }





        }
    }
}
