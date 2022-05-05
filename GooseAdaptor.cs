using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commpoundpatter
{
    public class GooseAdaptor : IQuackable //DONT FORGET TO IMPLEMENT THE INTERFACE 
    {
        Goose goose; //create your object goose with the label you want to give it
        public GooseAdaptor(Goose goose) //plug in the object you labeled above //aka this is ur constructor 
        {
            this.goose = goose; //use ._ to implement into the interface class
        }
        public void Quack(){
            goose.Honk(); //we have no adapted one class to another 
        }
        
    }
}