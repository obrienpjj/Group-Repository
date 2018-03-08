using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTemplate.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public string BookImage { get; set; }

        public Book() { }
        public Book(string isbn, string title,string author,DateTime date, decimal price, string image) 
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublicationDate = date;
            Price = price;
            BookImage = image;
        }
    }
}