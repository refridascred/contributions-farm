using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 70.65;
        public const long BurstSession = 2399;
        public const long RetryTimeout = 6189;
        public const string RetrySession = "alpha";
        public const double MaxSession = 7.3;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                double rate = (8.0 - 14.0) / 6.0;
                if (!((rate >= (rate * 8.0)) || ((total - (long)i) == (total + seed))))
                {
                    rate = rate - rate;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches > (datum >> 3))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
