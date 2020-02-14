using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.BehaviorImplementation
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak, squeak");
        }
    }
}
