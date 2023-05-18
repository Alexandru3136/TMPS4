using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4TMPS
{
    // Observatorul (Observer) 2
    public class Observer2 : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Observer2: The state has changed to " + value);
        }
    }


}
