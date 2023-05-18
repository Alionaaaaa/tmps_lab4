using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Behavioral
{
    public class Library
    {
        private List<IObserver> observers = new List<IObserver>();
        private IBookValidationHandler validationHandler;

        public void SetValidationHandler(IBookValidationHandler handler)
        {
            validationHandler = handler;
        }

        public void AddBookToLibrary(string bookTitle)
        {
            if (validationHandler.ValidateBook(bookTitle))
            {
                Console.WriteLine($"Book added to the library: {bookTitle}");
                NotifyObservers(bookTitle);
            }
            else
            {
                Console.WriteLine($"Book {bookTitle} is not valid and cannot be added to the library.");
            }
        }

        public void RemoveBookFromLibrary(string bookTitle)
        {
            Console.WriteLine($"Book removed from the library: {bookTitle}");
            NotifyObservers(bookTitle);
        }

        public void NotifyObservers(string bookTitle)
        {
            foreach (var observer in observers)
            {
                observer.Update(bookTitle);
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }
    }

}
