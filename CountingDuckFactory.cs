using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commpoundpatter
{
    public class CountingDuckFactory : AbstractDuckFactory //use abstract class because i HAVE to create all four methods
    {
        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateMallardDuck()
        {
           return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedHeadDuck()
        {
            return new QuackCounter(new RedHeadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}