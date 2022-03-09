using System;

namespace Hippo
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string new_title, string new_auhtor, int num_pages)
        {
            title = new_title;
            author = new_auhtor;
            pages = num_pages;
        }
        public void print_info()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Pages: " + pages);
        }
    }
}
