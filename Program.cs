using System;

namespace commpoundpatter // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulate();
        }
        public static void Simulate() //programs in program.cs are almost always static
        {

        //    IQuackable mallard = new QuackCounter(new MallardDuck());
        //     IQuackable redHead = new QuackCounter(new RedHeadDuck());
        //     IQuackable duckCall = new QuackCounter(new DuckCall());
        //     IQuackable rubberDuck = new QuackCounter(new RubberDuck());
        //     IQuackable gooseDuck = new GooseAdaptor(new Goose()); 
            // above was implementing the interface with the new adaptor 


            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            IQuackable mallard = duckFactory.CreateMallardDuck();
            IQuackable redHead = duckFactory.CreateRedHeadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();

            IQuackable gooseDuck = new GooseAdaptor(new Goose());

            System.Console.WriteLine("simulation is now starting");
            Simulate(mallard);
            Simulate(redHead);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            System.Console.WriteLine("The Ducks Quacked " + QuackCounter.GetNumberOfQuacks() + " Times");
        }
        public static void Simulate(IQuackable duck){
            duck.Quack();
        }
    }
}