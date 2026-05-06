using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Models
{
    internal class BookManager
    {
        public List<Book> Books { get; set; }
        public Dictionary<string, List<Book>> BooksByAuthor { get; set; }
        public Queue<string> WaitingQueue { get; set; }
        public Stack<Book> RecentlyReturned { get; set; }
        public Stack<Book> ReturnBooksStack { get; set; }

        public BookManager()
        {
            Books = new List<Book>();
            BooksByAuthor = new Dictionary<string, List<Book>>();
            WaitingQueue = new Queue<string>();
            RecentlyReturned = new Stack<Book>();
            ReturnBooksStack= new Stack<Book>();
        }


        public void AddBook(Book book)
        {
            Books.Add(book);
            if ( BooksByAuthor.ContainsKey(book.Author)==false)
            {
                BooksByAuthor[book.Author]=new List<Book>();
            }
            BooksByAuthor[book.Author].Add(book);
            Console.WriteLine($"kitab elave edildi : {book.Title}");
        }

        public  Book SearchByTitle(string title)
        {
           
            foreach (Book item in (Books))
            {
                if (item.Title== title)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Book>GetBooksByAuthor(string author)
        {
            
            if (BooksByAuthor.ContainsKey(author))
            {
                return BooksByAuthor[author];
                
            }
            else
            {
                return  new List<Book>();
            }
        }

        public void AddToWaitingQueue(string memberName)
        {
            WaitingQueue.Enqueue(memberName);
            Console.WriteLine($"{memberName} novbeye elave olundu ");
        }

        public string ServeNextlnQuene()
        {
            if (WaitingQueue.Count>0)
            {
                string nextPerson = WaitingQueue.Dequeue();
                return nextPerson;
            }
            else
            {
                return null;
            }
        }

        public void ReturnBook(Book book)
        {
            ReturnBooksStack.Push(book);
            Console.WriteLine($"Kitab qebul edildi: {book.Title}");
        }

        public Book GetLastReturnedBook()
        {
            if (ReturnBooksStack.Count>0)
            {
                return ReturnBooksStack.Peek();
            }
            else
            {
                return null;
            }
        }
    }
}
