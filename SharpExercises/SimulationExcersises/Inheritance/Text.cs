﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.SimulationExcersises.Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a hyperlink to " + url);
        }

    }
}
