using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commpoundpatter
{
    public class QuackCounter : IQuackable //this is the wrapper / decorator 
    {
        IQuackable duck; //interface and label it 
        static int numberofQuacks; //implement the count that you want as STATIC
        public QuackCounter(IQuackable duck) //this is from line 10
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            numberofQuacks++;
        }
        public static int GetNumberOfQuacks()
        {
            return numberofQuacks;
        }
    }
}