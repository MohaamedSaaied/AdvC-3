namespace AdvC_3
{
    public delegate string BookFuctionsDel(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Part 01:


            #region Class Implementation

            ////Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:
            ////You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: 
            ////Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            ////Use the Proper build in delegate. 

            //List<Book> b = new List<Book> {
            // new Book("1kz", "Title1","mohamed",DateTime.Now,5),
            // new Book("zhk3", "Title2","Ahmedd",DateTime.Now,16),
            // new Book("jhk8", "Title3","Ali",DateTime.Now,10),
            //};
            //LibraryEngine.ProcessBooks(b, BookFuctions.GetTitle);

            #endregion


            #region Anonymous Method (GetISBN).

            //Book b1 = new Book("1kz", "Title1", "mohamed", DateTime.Now, 5);
            //Func<Book,string> predicate;
            //predicate = delegate (Book book) { return book.ISBN; };
            //Console.WriteLine(predicate(b1));

            #endregion


            #region Lambda Expression (GetPublicationDate).

            //Book b2 = new Book("1kz", "Title1", "mohamed", DateTime.Now, 5);
            //Func<Book ,string>
            //Func=(Book book) =>  $"{book.PublicationDate}"; ;
            //Console.WriteLine(Func(b2));

            #endregion

            #endregion


            #region Part 02:

            ////We need to Implement the List methods from scratch with all overloads.


            //List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            //Helper<int> L = new Helper<int>();

            ////Exist
            //Console.WriteLine("Exists: " + L.Exists(list, x => x == 3));
            ////Find
            //Console.WriteLine("Find: " + L.Find(list, x => x > 3));
            ////Find All
            //Console.WriteLine("FindAll: " + string.Join(",", L.FindAll(list, x => x > 2)));
            ////Find index
            //Console.WriteLine("FindIndex: " + L.FindIndex(list, x => x == 4));
            ////Find Last
            //Console.WriteLine("FindLast: " + L.FindLast(list, x => x < 4));
            ////Find Last Index
            //Console.WriteLine("FindLastIndex: " + L.FindLastIndex(list, x => x < 4));
            ////Foreach
            //Console.WriteLine("ForEach:");
            //L.ForEach(list, x => Console.WriteLine(x));
            ////TrueForAll
            //Console.WriteLine("TrueForAll: " + L.TrueForAll(list, x => x > 0));


            #endregion


        }
    }
}
