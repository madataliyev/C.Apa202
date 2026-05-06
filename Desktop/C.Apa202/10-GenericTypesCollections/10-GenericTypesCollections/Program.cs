using _10_GenericTypesCollections.Models;
using System;
namespace _10_GenericTypesCollections
{
    class Proqram
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ag Gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qiriq Budaq", "Elcin", 1909, 400);

            Console.WriteLine("---KItab Melumatlari___");
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();


            Library<Book> milliKitabxana = new Library<Book>("Milli Kitabxana");
            milliKitabxana.Add(book1);
            milliKitabxana.Add(book2);
            milliKitabxana.Add(book3);
            milliKitabxana.Add(book4);
            milliKitabxana.Add(book5);

            Console.WriteLine($"Kitab sayi: {milliKitabxana.Count()}");
            Console.WriteLine("Indeks 0-daki kitab:");
            milliKitabxana.FindByIndex(0).DisplayInfo();
            Console.WriteLine("Indeks 2-deki kitab:");
            milliKitabxana.FindByIndex(2).DisplayInfo();

            Console.WriteLine($"Butun kitablar:");
            foreach (var b in milliKitabxana.GetAll())
            {
                Console.WriteLine($" {b.Title}");
            }
            Console.WriteLine();


            List<Member> members = new List<Member>();
            Member m1 = new Member(1, "Ali Mammadov", "ali@mail.com");
            Member m2 = new Member(2, "Leyla Hasanova", "leyla@mail.com");
            Member m3 = new Member(3, "Vuqar Aliyev", "vuqar@mail.com");
            members.Add(m1);
            members.Add(m2);
            members.Add(m3);


            m1.BorrowBook(book1);
            m1.BorrowBook(book2);
            Console.WriteLine($"{m1.Name} terefinden borc alinan kitablar:");
            m1.DisplayBorrowedBooks();

            m1.ReturnBook(1); 
            Console.WriteLine("Qaytarildiqdan sonra borc kitablar:");
            m1.DisplayBorrowedBooks();


            m2.BorrowBook(book3);
            m2.BorrowBook(book4);
            m2.BorrowBook(book5);
            m2.BorrowBook(book1); 
            Console.WriteLine();

            BookManager manager = new BookManager();
            manager.AddBook(book1);
            manager.AddBook(book2);
            manager.AddBook(book3);
            manager.AddBook(book4);
            manager.AddBook(book5);

            void PrintAuthorBooks(string author)
            {
                var books = manager.GetBooksByAuthor(author);
                Console.WriteLine($"{author} ucun tapilan kitab sayi: {books.Count}");
                foreach (var b in books) Console.WriteLine($" {b.Title}");
            }

            PrintAuthorBooks("George Orwell");
            PrintAuthorBooks("Cingiz Aytmatov");
            PrintAuthorBooks("Jack London");
            PrintAuthorBooks("Dostoyevski");
            Console.WriteLine();

            Queue<string> waitingQueue = new Queue<string>();
            waitingQueue.Enqueue("Nigar");
            waitingQueue.Enqueue("Resad");
            waitingQueue.Enqueue("Sabina");

            Console.WriteLine($"Novbede nece nefer var: {waitingQueue.Count}");
            Console.WriteLine($"Xidmet edilir: {waitingQueue.Dequeue()}");
            Console.WriteLine($"Qalan say: {waitingQueue.Count}");
            waitingQueue.Dequeue();
            Console.WriteLine($"Daha 1 nefer cixdi, qalan: {waitingQueue.Count}");
            waitingQueue.Dequeue();
            Console.WriteLine($"Novbe bosdurmu: {waitingQueue.Count == 0}");
            Console.WriteLine();

            Stack<Book> recentlyReturned = new Stack<Book>();
            recentlyReturned.Push(book1);
            recentlyReturned.Push(book2);
            recentlyReturned.Push(book3);

            Console.WriteLine($"Stack-de kitab sayi: {recentlyReturned.Count}");
            Console.WriteLine($"Son qaytarilan kitab: {recentlyReturned.Peek().Title}");
            recentlyReturned.Pop();
            Console.WriteLine($"1 kitab cixdi. Indi say: {recentlyReturned.Count}");
            Console.WriteLine($"Yeniden sonuncu: {recentlyReturned.Peek().Title}");
            Console.WriteLine();

            Book foundBook = manager.SearchByTitle("1984");
            if (foundBook != null) Console.WriteLine($"Tapildi: {foundBook.Title}");

            Book notFound = manager.SearchByTitle("Harry Potter");
            if (notFound == null) Console.WriteLine("Harry Potter tapilmadi ");
            Console.WriteLine();

            Console.WriteLine(" SISTEM STATISTIKASI ");
            Console.WriteLine($"Umumi kitab sayi: {milliKitabxana.Count()}");
            Console.WriteLine($"Umumi uzv sayi: {members.Count}");
            Console.WriteLine($"Novbede gozleyen: {waitingQueue.Count}");
            Console.WriteLine($"Stack-deki kitab sayi: {recentlyReturned.Count}");

            int minYear = int.MaxValue;
            int maxYear = int.MinValue;
            foreach (var b in milliKitabxana.GetAll())
            {
                if (b.Year < minYear) minYear = b.Year;
                if (b.Year > maxYear) maxYear = b.Year;
            }
            Console.WriteLine($"En kohne kitab ili: {minYear}");
            Console.WriteLine($"En yeni kitab ili: {maxYear}");
        }


      
        
    }
}




