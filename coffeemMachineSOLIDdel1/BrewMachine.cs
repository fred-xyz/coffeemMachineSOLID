using System;
using System.Collections.Generic;
using System.Text;

namespace coffeemMachineSOLIDdel3
{
    class BrewMachine
    {
        private int water;
        private int brewmaterial;
        private bool filter;

        public int Wather { get => water; set => water = value; }
        public int Brewmaterial { get => brewmaterial; set => brewmaterial = value; }
        public bool Filter { get => filter; set => filter = value; }

        public BrewMachine(int water_, int brewmaterial_, bool filter_)
        {
            this.Wather = water_;
            this.Brewmaterial = brewmaterial_;
            this.Filter = filter_;
        }
    }
}
