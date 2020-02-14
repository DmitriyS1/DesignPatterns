using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck(
            IFlyBehavior flyBehavior, 
            IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck! Hello!");
        }
    }
}
