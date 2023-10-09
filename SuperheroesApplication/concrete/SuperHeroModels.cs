using Superheroes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.Models
{
   

    public abstract class Alien : SuperHero
    {
       
    }

    public class Superman : Alien, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flying without wings");
        }
    }

    public abstract class Human : SuperHero
    {
        
    }
    public class Batman : Human, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flying with a cape");
        }
    }

    public abstract class Mutant : SuperHero
    {
      
    }

    public class Wolverine : Mutant
    {
        
    }



}
