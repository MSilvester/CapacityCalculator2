﻿using System;
using System.Collections.Generic;


namespace Capacity_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Github comment


            double pigNumber = PigNumber();                                                            // Asks for the input of number of pigs for deboning.
            (double aCapacity, double aStundenlohn) = Attendance();                                    // Asks for attendance and returns total avalable capacity and cost per hour.
            Capacity(aCapacity, pigNumber);                                                            // Calculates overtime or reserve capacity.
            TotalCost(Capacity(aCapacity, pigNumber), aStundenlohn);                                   // Calculates total cost of production.
            Result(Capacity(aCapacity, pigNumber), TotalCost(Capacity(aCapacity, pigNumber), aStundenlohn), pigNumber, aCapacity);  // Calculates the overtime/available additional hours, price per kilo of produce and total cost of labor.
        }
        private static double Capacity(double cap, double ord)
        {
            double result = ((ord / cap) * 8) - 8;
            return result;
        }
        private static double TotalCost(double aCap, double aStl)
        {
            double ttlCost = (8 + aCap) * aStl;
            return ttlCost;
        }
        private static double PigNumber()
        {
            try
            {
                Console.WriteLine("Enter number of pigs to be deboned: ");
                double order = int.Parse(Console.ReadLine());
                return order;
            }
            catch
            {
                Console.WriteLine("Please input number");
                return PigNumber();
            }
        }
        private static (double aCapacity, double aStundenlohn) Attendance()

        {
            Worker gregor = new Worker("Gregor", 1.62, 12);
            Worker andrej = new Worker("Andrej", 1.87, 12);
            Worker sebastian = new Worker("Sebastian", 1.87, 13);
            Worker stefan = new Worker("Stefan", 1.0, 11);
            Worker eugen = new Worker("Eugen", 1.25, 10);
            Worker tomas = new Worker("Tomas", 1.87, 12);
            Worker mathias = new Worker("Mathias", 1.87, 15);

            double sumCap = 0, sumStl = 0;

            Start1:
            Console.Write("Is {0} present? (y/n): ", gregor.Name);
            string gr = Console.ReadLine();

            if (gr.ToLower() == "y")
            {
                sumCap += gregor.Capacity;
                sumStl += gregor.StundenLohn;
            }
            else 
            {
                sumCap += 0;
                sumStl += 0;
            }
          


            Console.Write("Is {0} present? (y/n): ", andrej.Name);
            string an = Console.ReadLine();

            if (an.ToLower() == "y")
            {
                sumCap += andrej.Capacity;
                sumStl += andrej.StundenLohn;
            }
            else 
            {
                sumCap += 0;
                sumStl += 0;
            }
          

            Console.Write("Is {0} present? (y/n): ", sebastian.Name);
            string se = Console.ReadLine();

            if (se.ToLower() == "y")
            {
                sumCap += sebastian.Capacity;
                sumStl += sebastian.StundenLohn;
            }
            else 
            {
                sumCap += 0;
                sumStl += 0;
            }
            

            Console.Write("Is {0} present? (y/n): ", stefan.Name);
            string st = Console.ReadLine();

            if (st.ToLower() == "y")
            {
                sumCap += stefan.Capacity;
                sumStl += stefan.StundenLohn;
            }
            else { 
                sumCap += 0;
                sumStl += 0;
            }
            

            Console.Write("Is {0} present? (y/n): ", eugen.Name);
            string eu = Console.ReadLine();

            if (eu.ToLower() == "y")
            {
                sumCap += eugen.Capacity;
                sumStl += eugen.StundenLohn;
            }
            else  
            {
                sumCap += 0;
                sumStl += 0;
            }

            Console.Write("Is {0} present? (y/n): ", tomas.Name);
            string to = Console.ReadLine();

            if (to.ToLower() == "y")
            {
                sumCap += tomas.Capacity;
                sumStl += tomas.StundenLohn;
            }
            else  
            {
                sumCap += 0;
                sumStl += 0;
            }

            Console.Write("Is {0} present? (y/n): ", mathias.Name);
            string ma = Console.ReadLine();

            if (ma.ToLower() == "y")
            {
                sumCap += mathias.Capacity;
                sumStl += mathias.StundenLohn;
            }
            else 
            {
                sumCap += 0;
                sumStl += 0;
            }
            
            return ((sumCap * 8), sumStl);



        }
        private static void Result(double c, double tc, double pn, double acp)
        {
            double ppkg = tc / (pn * 80);       // 80 is an average weight of the pork carcass


            if (c < 0)
            {
                Console.WriteLine("There will be {0} work hours available.", Math.Abs(Math.Round(c, 2)));
                Console.WriteLine("Labour price is {0} eur per kilo.", Math.Round(ppkg, 3));
                Console.WriteLine("Total cost of labor for production will be: " + Math.Round(tc), 2);
            }
            else if (c > 4)
            {
                Console.WriteLine("Work order cannot be completed in one day.");
            }
            else
            {
                Console.WriteLine("There will be {0} hours overtime", Math.Round(c, 2));
                Console.WriteLine("Pig deboning capacity without overtime is: " + Math.Round(acp, 2));
                Console.WriteLine("Labour price is {0} eur per kilo.", Math.Round(ppkg, 3));
                Console.WriteLine("Total cost of labor for production will be: " + Math.Round(tc), 2);
            }
        }

    }

}

