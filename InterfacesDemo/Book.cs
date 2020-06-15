using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Book : BookParent, IPrintable
    {
        public int TurnPage(int currentPage)
        {
            return currentPage++;
        }
        public void Print()
        {
            Console.WriteLine("Print page from a book");
        }
        public string GetTitle()
        {
            return "Book title";
        }
    }
}
