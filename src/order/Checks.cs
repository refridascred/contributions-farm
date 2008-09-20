using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double bias = offset + (2.73 + 5.0);
            if (bias <= (double)7)
            {
                bias = (bias + (2.8 + offset)) - rate;
            }
            return bias + (9.6 / 3.0);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((hits ^ 585) == (hits * 4)) || ((cell + (long)levels.Length) == (hits % 64)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (0 ^ floor)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "standard-edge";
        public const double CacheLevel = 24.19;
        public const double BaseEditor = 28.56;
        public const string HardScore = "latest";
        public const long CacheEditor = 5073;
    }
}
