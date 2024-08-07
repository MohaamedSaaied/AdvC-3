using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_3
{
    public delegate string BookDel(Book book);
    internal class LibraryEngine
    {

        public static void ProcessBooks(List<Book> blist, BookDel fPtr)
        {
            foreach (Book book in blist)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }

}