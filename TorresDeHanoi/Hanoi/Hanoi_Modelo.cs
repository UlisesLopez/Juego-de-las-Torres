using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Hanoi
{
    class Hanoi_Modelo
    {
        public Stack Torre1 { get; set; }
        public Stack Torre2 { get; set; }
        public Stack Torre3 { get; set; }

        public Hanoi_Modelo()
        {
            Torre1=new Stack();
            Torre2 = new Stack();
            Torre3 = new Stack();
        }


        public void Clear()
        {
            Torre1.Clear();
            Torre2.Clear();
            Torre3.Clear();
        }
    }
}
