using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Behavioral
{
    public interface IBookValidationHandler
    {
        bool ValidateBook(string bookTitle);
        void SetNextHandler(IBookValidationHandler handler);
    }

    // Concrete Handler 1
    public class TitleValidationHandler : IBookValidationHandler
    {
        private IBookValidationHandler nextHandler;

        public bool ValidateBook(string bookTitle)
        {
            if (bookTitle.Length >= 5)
            {
                return true;
            }
            else if (nextHandler != null)
            {
                return nextHandler.ValidateBook(bookTitle);
            }
            else
            {
                return false;
            }
        }

        public void SetNextHandler(IBookValidationHandler handler)
        {
            nextHandler = handler;
        }
    }

    // Concrete Handler 2
    public class AuthorValidationHandler : IBookValidationHandler
    {
        private IBookValidationHandler nextHandler;

        public bool ValidateBook(string bookTitle)
        {
            if (bookTitle.Contains("by"))
            {
                return true;
            }
            else if (nextHandler != null)
            {
                return nextHandler.ValidateBook(bookTitle);
            }
            else
            {
                return false;
            }
        }

        public void SetNextHandler(IBookValidationHandler handler)
        {
            nextHandler = handler;
        }
    }
}
