using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_11._1
// Create a books inventory with all necessary fields like ISBN, Name ,author name, description of book. ISBN can be primary key.
// Use code first approach.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Inventory Pseudodatabase");
            
        }
    }

    public class BookInventory
    {
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }

        public List<BookInventory> bookInventories = new List<BookInventory>
        {
            new BookInventory
            {
                ID = 1,
                ISBN = "123456789",
                Name = "The Very First Book",
                AuthorName = "Aww Thor",
                Description = "A super cool book about something amazing."
            },
            new BookInventory
            {
                ID = 2,
                ISBN = "234567891",
                Name = "The Very Second Book",
                AuthorName = "Ron Old",
                Description = "A cool book written by Aww Thor's nemesis."
            },
            new BookInventory
            {
                ID= 3,
                ISBN = "345678912",
                Name = "Just Another Book",
                AuthorName = "See Goal",
                Description = "A creative book written from the perspective of a seagull."
            },
        };
        
    }

    

}
