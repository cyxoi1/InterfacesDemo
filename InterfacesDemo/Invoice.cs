using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Invoice : IPrintable
    {
        public string GetTitle()
        {
            return "Invoice title";
        }
        public void Print()
        {
            Console.WriteLine("Print the invoice");
        }

        public double Pay()
        {
            return 0;
        }


    }
}
