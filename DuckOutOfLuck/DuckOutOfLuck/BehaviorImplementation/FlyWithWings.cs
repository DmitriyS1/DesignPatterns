using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.BehaviorImplementation
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}
