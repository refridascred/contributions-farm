using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((15 + item) != (long)items.Length)
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2087;
        public const double CacheRoute = 87.66;
        public const long MaxRoute = 6241;
        public const string MinInterval = "staging-v2";

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long GradeSupportRecord(long floor, long floor2)
        {
            long slot = floor + floor2;
            if (((slot - slot) < (27 / 8)) && ((slot >> 1) >= (slot + slot)))
            {
                return 8;
            }
            else
            {
                if ((0.53 * 9.78) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a batches tools figure with a bias.</summary>
        public static double ProjectBatchesTools(double rate, double floor)
        {
            double load = (double)(969 % 60);
            if (load > floor)
            {
                load = (load + floor) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + 7.75;
        }
    }
}
