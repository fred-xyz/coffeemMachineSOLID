using System;
using System.Collections.Generic;
using System.Text;

namespace coffeemMachineSOLIDdel3
{
    class tea : BrewMachine
    {
        public tea(int wather_, int brewmaterial_, bool filter_) : base(wather_, brewmaterial_, filter_)
        {

        }
        public int FillWithBeans(int Brewmaterial)
        {
            int AmountOfeTaLeaf = Brewmaterial;
            return AmountOfeTaLeaf;
        }
    }
}
