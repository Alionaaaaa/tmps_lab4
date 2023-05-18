using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Behavioral
{
    // Concrete Strategy 1
    public class EmailNotificationStrategy : IBookNotificationStrategy
    {
        public void NotifyObservers(List<IObserver> observers, string bookTitle)
        {
            Console.WriteLine($"Sending email notification to observers about the book: {bookTitle}");
            foreach (var observer in observers)
            {
                observer.Update(bookTitle);
            }
        }
    }

    // Concrete Strategy 2
    public class SMSNotificationStrategy : IBookNotificationStrategy
    {
        public void NotifyObservers(List<IObserver> observers, string bookTitle)
        {
            Console.WriteLine($"Sending SMS notification to observers about the book: {bookTitle}");
            foreach (var observer in observers)
            {
                observer.Update(bookTitle);
            }
        }
    }
}
