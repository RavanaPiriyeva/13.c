using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Notebook:Product
    {
   
        public int RAM { get; set; }
        public int Storage { get; set; }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}   RAM: {RAM}    Storage:{Storage}";
        }
    }

}
