using coffeemMachineSOLIDdel1;
using System;

namespace coffeemMachineSOLIDdel3
{
    class Program
    {
        static void Main(string[] args)
        {
            BrewEspresso amoutofcup = new BrewEspresso(2,2,true,5);
            amoutofcup.BrewAllTheCups();
        }
    }
}
