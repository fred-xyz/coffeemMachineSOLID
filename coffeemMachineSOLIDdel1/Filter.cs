using System;
using System.Collections.Generic;
using System.Text;

namespace coffeemMachineSOLIDdel3
{
    class Filter : BrewMachine
    {
        public Filter(int wather_, int brewmaterial_, bool filter_) : base(wather_, brewmaterial_, filter_)
        {

        }

        public string ChackFilter(bool Filter)
        {
            if(Filter == false)
            {
                return "ther a no filter in the Machine. you a bad a makin coffee";
            }
            return "the filter is in the CoffeeMachine";
        }
    }
}
