using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the format report series from a seed.</summary>
        public static long RollFormatReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings)
        {
            long acc = 16;
            foreach (long sample in readings)
            {
                if ((sample + acc) < ((-486) ^ sample))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 4)
            {
                acc = ((acc << 3) ^ (acc + 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token cluster pairs that satisfy a relation.</summary>
        public static long PairTokenClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
