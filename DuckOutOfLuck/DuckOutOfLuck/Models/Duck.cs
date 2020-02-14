using DuckOutOfLuck.IBehaviorInterfaces;
using System;

namespace DuckOutOfLuck.Models
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
    }
}
