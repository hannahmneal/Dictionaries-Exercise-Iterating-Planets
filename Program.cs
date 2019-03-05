using System;
using System.Collections.Generic;

namespace practice_iterating_planets
{
    class IteratingPlanets
    {
        static void Main(string[] args)
        {
            /*
                1. Use the list of planets you created in the previous chapter or create a new one with all eight planets.
             */

            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            /*
                2. Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.
             */

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add(new Dictionary<string, string>() { { "Mercury", "Mariner 10" } });
            probes.Add(new Dictionary<string, string>() { { "Venus", "Mariner 1" } });
            probes.Add(new Dictionary<string, string>() { { "Mars", "Mariner 3" } });
            probes.Add(new Dictionary<string, string>() { { "Jupiter", "Pioneer 10" } });
            probes.Add(new Dictionary<string, string>() { { "Saturn", "Cassini" } });
            probes.Add(new Dictionary<string, string>() { { "Uranus", "Voyager 2" } });
            probes.Add(new Dictionary<string, string>() { { "Neptune", "Voyager 2" } });
            /*
               3. Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
             */

            foreach (string planet in planetList) // iterate planets
            /*
                planet: "Mercury" (one of the planets in the list)
                planetList:
                    [0]: "Mercury"
                    [1]: "Venus" ........
             */

            {
                // Console.WriteLine($"Iteration of each planet in planetList: {planet}");
                List<string> matchingProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probes) // iterate probes

                /*
                    "probes" is the List and each Dictionary in it is a "probe"; you need to link "probes" and "planets"

                    probe:
                        {[Mercury, Mariner 10]}
                        {[Venus, Mariner 1]}

                    probes:
                        [0]: {[Mercury, Mariner 10]}
                        [1]: {[Venus, Mariner 1]} ......
                 */

                {
                    foreach (KeyValuePair<string, string> probeItem in probe)
                    {

                        // Console.WriteLine($"Iteration of each probeItem in probe: {probeItem}");
                        /*
                            If this WriteLine runs before the if statement, each planet name and probe name is displayed 8 times to the console.
                         */
                        // string planetName = probeItem.Key;
                        // Console.WriteLine($"planetName (probeItem.Key): {planetName}");

                        /*
                            Does the current Dictionary contain the key of
                            the current planet? Investigate the ContainsKey()
                            method on a Dictionary.

                            If so, add the current spacecraft to `matchingProbes`.
                        */

                        if (probe.ContainsKey(planet))
                        {
                            matchingProbes.Add(probe[planet]);
                            // String.Join(",", matchingProbes);
                            Console.WriteLine($"{planet}, {String.Join(",", matchingProbes)}");
                        }
                        //     string planet = String.Join(",", matchingProbes);
                        // Console.WriteLine($"probe[probeItem.Key]: {probe[probeItem.Key]}");
                        // Console.WriteLine($"probe[probeItem.Key]: {planet}");
                    }
                }
            }
        }

        /*
            Use String.Join(",", matchingProbes) as part of the
            solution to get the output below. It's the C# way of
            writing `array.join(",")` in JavaScript.
        */


        // Console.WriteLine($"{}: {}");
    }

}
