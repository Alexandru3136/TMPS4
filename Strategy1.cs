using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4TMPS
{
    // Implementarea strategiei (Strategy) 1
    public class Strategy1 : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing Strategy 1");
        }
    }
}
