using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4TMPS
{
    // Interfață pentru observator (Observer)
    public interface IObserver
    {
        void Update(int value);
    }
}
