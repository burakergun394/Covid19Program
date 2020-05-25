using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    interface Subject
    {
        void AddObserver(Observer o);
        void DeleteObserver(Observer o);
        void NotifyObserver();
    }
}
