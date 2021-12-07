using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionarySortedListKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //generik olmayan koleksiyon
            Hashtable Ht = new Hashtable();
            Ht.Add(1, "bir");
            Ht.Add(2, "iki");
            Ht.Add(3, "üç");


            //(key,value ) aynı key ikinci kez kaydedilemez
            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "bir");
            DictionaryList.Add(2, "iki");
            DictionaryList.Add(3, "üç");
            DictionaryList.Add(4, "dört");


            ////Dictionary yazdırma
            foreach (KeyValuePair<int,string> item in DictionaryList)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            //Liste içinde küçükten büyüğe sıralar
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            sortedlist.Add(100, "Yüz");
            sortedlist.Add(30,"otuz");





            Console.ReadLine();
        }
    }
}
