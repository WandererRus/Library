using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublishYear { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public Book(int id, string name, string author, string genre, int publishYear, int pages, string publisher) 
        { 
            Id = id;
            Name = name;
            Author = author;
            Genre = genre;
            Publisher = publisher;
            Pages = pages;
            PublishYear = publishYear;
        }
        public Book()
        {
            
        }
    }
}
