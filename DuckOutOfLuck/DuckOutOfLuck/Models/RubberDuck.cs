using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.Models
{
    public class RubberDuck : Duck
    {
        public RubberDuck(
            IFlyBehavior flyBehavior, 
            IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck!");
        }
    }
}
