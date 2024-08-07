using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_3
{
    internal class BookFuctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string GetAuthor(Book book)
        {
            return book.Author;
        }
        public static string GetPrice(Book book)
        {
            return $"{book.Price}";
        }

    }
}
