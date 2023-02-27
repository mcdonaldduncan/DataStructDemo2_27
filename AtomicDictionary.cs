using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructDemo2_27
{
    internal class AtomicDictionary
    {
        Dictionary<string, int> atomicweights = new Dictionary<string, int>();

        Dictionary<Species, List<Animal>> speciesDict = new Dictionary<Species, List<Animal>>();

        public void Run()
        {
            atomicweights.Add("hydrogen", 1); // here we are using the Add method to add key/value pairs
            atomicweights.Add("helium", 2); // you can add the values when you create the Dictionary, too
            atomicweights.Add("lithium", 3); // see next section for an example
            atomicweights.Add("beryllium", 4);

            foreach (var item in atomicweights)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            foreach (var key in atomicweights.Keys)
            {
                Console.WriteLine($"{key}");
                Console.WriteLine($"{atomicweights[key]}");
            }

            foreach (var val in atomicweights.Values)
            {
                Console.WriteLine($"{val}");
            }

            string h = "hydrogen";
            int hVal = 1;

            // users are adding new elements to the dictionary and you recieve a new entry from the string and int above
            if (atomicweights.ContainsKey(h))
            {
                //dosomething
            }

            if (atomicweights.ContainsValue(hVal))
            {
                //dosomething
            }

        }

    }
}
