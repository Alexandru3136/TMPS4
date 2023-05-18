using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4TMPS
{
    // Observatorul (Observer) 1
    public class Observer1 : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Observer1: The state has changed to " + value);
        }
    }
}
