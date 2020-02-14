using DuckOutOfLuck.BehaviorImplementation;
using DuckOutOfLuck.Models;
using System;
using System.Collections.Generic;

namespace DuckOutOfLuck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new MallardDuck(new FlyWithWings(), new QuackDefault()),
                new RubberDuck(new FlyNoWay(), new Squeak())
            };

            foreach (var duck in ducks)
            {
                Console.WriteLine("__________________________________________________");
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                duck.Swim();
            }

            Console.ReadLine();
        }
    }
}
