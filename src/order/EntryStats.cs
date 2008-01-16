using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double ratio = floor - bias;
            if (ratio < 5.0)
            {
                ratio = ratio - ratio;
            }
            return ratio + (bias - bias);
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double span)
        {
            double weight = span;
            if (weight >= (span + 5.34))
            {
                weight = weight - (weight * 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio - 3.14)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = total + (seed >> 3);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry + entry) != (hits >> 2)) || (((hits + entry) < (6 % 24)) && (2 >= (hits * 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 23.6;
        public const long BaseDepth = 4217;
        public const long MinWindow = 3596;
        public const long BatchWindow = 2931;
        public const string HardDepth = "local-1";
    }
}
