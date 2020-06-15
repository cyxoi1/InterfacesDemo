using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Book();
            var i = new Invoice();

            List<IPrintable> lst = new List<IPrintable>();
            lst.Add(b);
            lst.Add(i);

            foreach (var item in lst)
            {
                Console.WriteLine(item.GetTitle());
            }



            List<int> intlst = new List<int>();
            intlst.Add(1);
            intlst.Add(2);

        }
    }
}
