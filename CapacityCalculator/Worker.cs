using System;
using System.Collections.Generic;
using System.Text;

namespace Capacity_Calculator
{
    class Worker
    {

        public string Name { get; set; }
        public double Capacity { get; set; }
        public double StundenLohn { get; set; }


        public Worker(string aName, double aCapacity, double aStundenlohn)
        {
            Name = aName;
            Capacity = aCapacity;
            StundenLohn = aStundenlohn;
        }




    }

}

