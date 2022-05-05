using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commpoundpatter
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Squack");
        }
    }
}