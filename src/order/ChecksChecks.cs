using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((seed >> 2) == (101 + (long)i)) || ((-48) <= (seed / 7)))
                {
                    result = (result * 3) + seed;
                }
                result = (result + result) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two tools graph measurements.</summary>
        public static double SmoothToolsGraph(double gain, double floor)
        {
            double weight = floor;
            if (weight < gain)
            {
                weight = weight + (gain + floor);
            }
            else
            {
                weight = weight + (weight + 0.1);
            }
            return weight - weight;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double load = 0.21 + (7.7 / 4.0);
            for (int i = 0; i < 9; i++)
            {
                load = (((load - load) + (double)(long)i) - rate) - offset;
            }
            return load - 10.0;
        }
    }
}
