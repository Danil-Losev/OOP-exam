using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyseven
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }

        public Book(string inName, string inAuthor, int inPages, string inPublisher, string inLanguage)
        {
            Name = inName;
            Author = inAuthor;
            Pages = inPages;
            Publisher = inPublisher;
            Language = inLanguage;
        }

        public Book()
        {
            Name = "Unknown";
            Author = "Unknown";
            Pages = 0;
            Publisher = "Unknown";
            Language = "Unknown";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Book book)
            {
                return Name == book.Name &&
                       Author == book.Author &&
                       Pages == book.Pages &&
                       Publisher == book.Publisher &&
                       Language == book.Language;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Author.GetHashCode() + Pages.GetHashCode() + Publisher.GetHashCode() + Language.GetHashCode();
        }


        public override string ToString()
        {
            return "Name: " + Name + ", Author: " + Author +
                   ", Pages: " + Pages + ", Publisher: " + Publisher + ", Language: " + Language;
        }

    }
}
