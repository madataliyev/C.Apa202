using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace _10_GenericTypesCollections.Models
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(int id ,string name , string email )
        {
            Id= id;
            Name= name;
            Email= email;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count<3)
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"KItab goturuldu {book.Title}");
            }
            else
            {
                Console.WriteLine("MAksimum 3 kitab goture bilersiz!");
            }

        }
        public void ReturnBook(int bookId)
        {
            Book tapilanKitab = null;
            foreach (var item in BorrowedBooks)
            {
                if (item.Id==Id)
                {
                    tapilanKitab = item;
                    break;

                }
            }
            if (tapilanKitab!=null)
            {
                BorrowedBooks.Remove(tapilanKitab);
                Console.WriteLine($"Kitab qaytarildi : {tapilanKitab.Title}");
            }
            else
            {
                Console.WriteLine("BU id e uygun kitab tapilmai");
            }
        }
        public void DisplayBorrowedBooks()
        {
           
            if (BorrowedBooks.Count ==0)
            {
                Console.WriteLine("Borc kitab yoxdur");
            }
            else
            {
                foreach (var item in BorrowedBooks)
                {
                    Console.WriteLine(item);
                }
            }
        }
        



    }
}
