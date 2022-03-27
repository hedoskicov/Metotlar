using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);


            foreach (var sehir in sehirler) 
            {
                Console.WriteLine(sehir);
            }

        }
    }

    class MyList<T>
    {
        T[] array;
        T[] templArray;

        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            templArray = array;
            array =  new T[array.Length + 1];
            for (int i = 0; i< templArray.Length; i++)
            {
                array[i] = templArray[i];
            }
            array[array.Length - 1] = item;

        }
        public int Count
        {
            get { return array.Length; }
        }

        public T[] arrays
        {
            get { return array; }
        }

    }
}
