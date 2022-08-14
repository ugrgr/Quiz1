﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class linQ
    {
        private static void ShowLINQ()
        {
            List<Element> elements = BuildList();

           
            var subset = from theElement in elements
                         where theElement.AtomicNumber < 22
                         orderby theElement.Name
                         select theElement;

            foreach (Element theElement in subset)
            {
                Console.WriteLine(theElement.Name + " " + theElement.AtomicNumber);
            }
        }

        private static List<Element> BuildList()
        {
            return new List<Element>
    {
        { new Element() { Symbol="Mg", Name="Magnesium", AtomicNumber=19}},
        { new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
        { new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
        { new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
        { new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
    };
        }

        public class Element
        {
            public string ?Symbol { get; set; }
            public string ?Name { get; set; }
            public int AtomicNumber { get; set; }
        }
    }
}
