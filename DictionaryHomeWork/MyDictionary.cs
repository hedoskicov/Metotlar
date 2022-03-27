using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomeWork
{
    internal class MyDictionary<K,V>
    {
       K[] Id;
       K[] TempId;
       V[] Price;
       V[] TempPrice;

        public MyDictionary()
        {
            Id = new K[0];
            Price = new V[0];
        }

        public void Add(K productId, V productPrice)
        {
            TempId = Id;
            Id =  new K[Id.Length + 1];
            for (int i = 0; i < TempId.Length; i++)
            {
                Id[i] = TempId[i];
            }
            Id[Id.Length - 1] = productId;

            TempPrice = Price;
            Price = new V[Price.Length + 1];
            for (int i = 0; i < TempPrice.Length; i++)
            {
                Price[i] = TempPrice[i];
            }
            Price[Price.Length - 1] = productPrice; 
        }

        public int CountId
        {
            get { return Id.Length; }
        }

        public int CountPrice
        {
            get { return Price.Length; }
        }

        public K[] Ids
        {
            get { return Id; }
        }

        public V[] Prices
        {
            get { return Price; }
        }
    }
}
