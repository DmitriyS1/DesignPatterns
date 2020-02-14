using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.BehaviorImplementation
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Don't fly");
        }
    }
}
