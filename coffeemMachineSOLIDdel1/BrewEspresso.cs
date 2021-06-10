using coffeemMachineSOLIDdel3;
using System;
using System.Collections.Generic;
using System.Text;

namespace coffeemMachineSOLIDdel1
{
    class BrewEspresso : CoffeeBeans
    {
        public int Cupofespresso { get; }

        public BrewEspresso(int wather_, int brewmaterial_, bool filter_, int Beans) : base(wather_, brewmaterial_, filter_)
        {
            this.Cupofespresso = Beans;
        }
        
        public int BrewAllTheCups()
        {
            int numberOfCups = 0;
            for (int i = 1; i < Cupofespresso; i++)
            {
                numberOfCups++;
                Console.WriteLine("this is cup number: " + numberOfCups);
            }
            Console.Write("you brew a totel nuber of: ");
            return numberOfCups;
        }
    }
}
