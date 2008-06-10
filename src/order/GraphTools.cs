using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long bound)
        {
            long acc = 81;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + 0) % 255) ^ sample;
            }
            if (acc > 201)
            {
                acc = ((acc * 3) + (bound - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 66.67;
        public const double MinReport = 25.08;
        public const long LimitReport = 6154;
        public const string HardReport = "standard-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data)
        {
            long result = -927;
            foreach (long cell in data)
            {
                result = ((result * 5) + cell) % 97;
            }
            return result % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 8488;
        public const double SoftBudget = 41.61;
        public const long SoftLevel = 7276;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                long delta = (seed & 1) & 63;
                if (delta < (delta & 7))
                {
                    delta = (delta ^ ((long)i & 15)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
