using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic
            Dictionary<int,string> kullanıcılar= new Dictionary<int, string>();
            kullanıcılar.Add(10,"yavuz kocar");
            kullanıcılar.Add(12,"bilal kocar");
            kullanıcılar.Add(16,"merve kocar");
            kullanıcılar.Add(13,"oznur kocar");
            

            //dizinin elemanlarına erişim
            Console.WriteLine("****dizinin elemanlarına erisim****");
            Console.WriteLine(kullanıcılar[12]);

            //count eleman sayısı
             Console.WriteLine("****count****");
            Console.WriteLine(kullanıcılar.Count);
            
            //contains - arama true veya false döner
             Console.WriteLine("****contains****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("yavuz kocar"));
            //Remove-listeden çıkarma
            Console.WriteLine("****remove****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item.Value);

            //keys
            Console.WriteLine("****keys****");
            foreach (var item in kullanıcılar.Keys)
            Console.WriteLine(item);
    
            //values
            Console.WriteLine("****values****");
            foreach (var item in kullanıcılar.Values)
            Console.WriteLine(item);


        }
    }
}
