using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public  class Phone:Product
    {
        public int SIMCount { get; set; }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}   Sim count:{SIMCount}";
        }
    }
}
