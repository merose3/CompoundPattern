using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commpoundpatter
{
    public abstract class AbstractDuckFactory //this method is only for the methods 
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedHeadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }
}