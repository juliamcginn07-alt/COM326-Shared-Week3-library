using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {

        private string Title;
        private string Author;
        private string ISBN;

       
        public string title
        {
            get { return Title; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    Title = value;
                }
                else
                {
                    Console.WriteLine("Error: Book name cannot be blank or contain numbers.");
                }
            }
        }

        public string author
        {
            get { return Author; }

            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    Author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author cannot be blank or contain numbers.");
                }
            }
        }

        public string isbn
        {
            get { return ISBN; }
            set
            {
                if (value.Any(char.IsDigit) && value != "")
                { ISBN = value; }
                else
                {
                    Console.WriteLine(" Error: Book ISBN cannot be blank or contain any numbers.");
                }
            }
        }





        public Book(string Title, string Author, string ISBN)
        {
            this.title = Title;
            this.author = Author;
            this.isbn = ISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Book ISBN: {isbn}");
            Console.WriteLine();
        }
    }
} 
    
