using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.BehaviorImplementation
{
    public class QuackDefault : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack, quack");
        }
    }
}
