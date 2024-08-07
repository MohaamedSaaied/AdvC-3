using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_3
{
     public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string ISBN, string Title, string Author, DateTime PublicationDate, decimal Price)
        {

            this.ISBN = ISBN;
            this.Title = Title;
            this.Author= Author;
            this.PublicationDate = PublicationDate;
            this.Price = Price;

        }
        public override string ToString()
        {
            return $"ISBN: {ISBN} , Title : {Title} , Author: {Author} , PublicationDate: {PublicationDate} , Price: {Price}";
        }
    }
}
