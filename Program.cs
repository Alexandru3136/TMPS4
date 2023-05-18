using System;
using System.Collections.Generic;

namespace L4TMPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizare Observer
            Subject subject = new Subject();
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.State = 10;

            subject.Detach(observer2);

            subject.State = 20;

            // Utilizare Strategy
            IStrategy strategy1 = new Strategy1();
            IStrategy strategy2 = new Strategy2();

            Context context = new Context(strategy1);
            context.ExecuteStrategy();

            context = new Context(strategy2);
            context.ExecuteStrategy();

            Console.ReadLine();
        }
    }
}