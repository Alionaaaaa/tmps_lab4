using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Behavioral
{
    public class User : IObserver
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public void Update(string bookTitle)
        {
            Console.WriteLine($"User {name}: Book {bookTitle} has been updated.");
        }
    }
}
