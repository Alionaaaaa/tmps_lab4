using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Behavioral
{
    public interface IBookNotificationStrategy
    {
        void NotifyObservers(List<IObserver> observers, string bookTitle);
    }
}
