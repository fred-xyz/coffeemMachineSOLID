using System;
using System.Collections.Generic;
using System.Text;

namespace coffeemMachineSOLIDdel3
{
    class CoffeeBeans : BrewMachine
    {
        public CoffeeBeans(int wather_, int brewmaterial_, bool filter_) : base(wather_, brewmaterial_, filter_)
        {

        }

        public int FillWithBeans(int Brewmaterial)
        {
            int AmountOfBeans = Brewmaterial;
            return AmountOfBeans;
        }
    }
}
