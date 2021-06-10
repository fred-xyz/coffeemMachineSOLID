using System;
using System.Collections.Generic;
using System.Text;

namespace coffeemMachineSOLIDdel3
{
    class Container : BrewMachine
    {
        public Container(int water_, int brewmaterial_, bool filter_) : base(water_, brewmaterial_, filter_)
        {

        }

        public int FillContainer(int Water)
        {
            int NumberOfCups = Water;
            return NumberOfCups;
        }
    }
}
