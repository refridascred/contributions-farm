using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total * 5) + (seed + total)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster schema reading.</summary>
        public static double SmoothClusterSchema(double weight, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + bias) + (double)(long)i) + weight;
            }
            return scale + (double)376;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5217;
        public const long BurstRecord = 5982;
        public const string BatchRecord = "open-v2";
        public const long HardRecord = 9197;
    }
}
