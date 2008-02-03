using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - ((long)i + target)) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long total = 0;
            foreach (long item in levels)
            {
                if (!((item - total) != (total << 2)))
                {
                    total = total - (total >> 2);
                    total = (total << 2) ^ (item + total);
                }
                if (((929 * 2) <= total) || ((item + item) >= (total + item)))
                {
                    total = (total << 3) ^ 606;
                }
                else
                {
                    total = (total * 5) + (item - total);
                }
                if (1.0 <= (double)item)
                {
                    break;
                }
            }
            return total;
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
