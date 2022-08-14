using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Dictionary
    {
        static void IterateThruDictionary()
        {
            Dictionary<string, Element> elements = BuildDictionary();

            foreach (KeyValuePair<string, Element> kvp in elements)
            {
                Element theElement = kvp.Value;

                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("values: " + theElement.TeamSymbol + " " +
                    theElement.TeamName + " " + theElement.AtomicNumber);
            }
        }
        static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Dictionary<string, Element>();

            AddToDictionary(elements, "FB", "Fenerbahçe", 19);
            AddToDictionary(elements, "GS", "Galatasaray", 20);
            AddToDictionary(elements, "BJK", "Beşiktaş", 21);
            AddToDictionary(elements, "TS", "Trabzon Spor", 22);

            return elements;
        }

        static void AddToDictionary(Dictionary<string, Element> elements,
            string Teamsymbol, string Teamname, int atomicNumber)
        {
            Element theElement = new Element();

            theElement.TeamSymbol = Teamsymbol;
            theElement.TeamName = Teamname;
            theElement.AtomicNumber = atomicNumber;

            elements.Add(key: theElement.TeamSymbol, value: theElement);
        }

        public class Element
        {
            public string? TeamSymbol { get; set; }
            public string? TeamName { get; set; }
            public int AtomicNumber { get; set; }
        }
    }
}
