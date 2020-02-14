using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.BehaviorImplementation
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("__");
        }
    }
}
