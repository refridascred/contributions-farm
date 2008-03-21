using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double load = (double)(35 & 15);
            if (load < (double)192)
            {
                load = load - (double)748;
            }
            else
            {
                load = load - (rate + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 5300;
        public const long StepRoute = 1619;
        public const long DefaultRatio = 6324;
        public const long MaxRoute = 5725;
        public const double LimitLevel = 72.27;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
