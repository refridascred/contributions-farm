using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long seed)
        {
            long span = step ^ seed;
            if (step >= (813 + 7))
            {
                return 8;
            }
            else
            {
                if (span > (step - step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double weight = (double)((-945) & 3);
            if (weight < (18.0 * 8.46))
            {
                weight = ((weight + weight) + gain) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchInterval = "staging-v2";
        public const long BaseContributi = 8633;
        public const string CacheContributi = "cached-1";
        public const long BatchSize = 6405;
    }
}
