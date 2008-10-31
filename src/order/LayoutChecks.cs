using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] series, long floor)
        {
            long mix = 56;
            foreach (long datum in series)
            {
                if ((double)datum <= (5.0 * 18.0))
                {
                    mix = ((mix * 2) + (811 + mix)) % 65521;
                }
                else
                {
                    mix = mix ^ floor;
                }
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1124;
        public const long RetrySize = 9103;
        public const string CacheSize = "staging-1";
        public const long BatchChannel = 9132;

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long result = 71;
            foreach (long entry in data)
            {
                result = ((result * 2) + 56) + entry;
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheBudget = 29.16;
        public const long BaseInterval = 3744;
        public const long BatchSize = 1975;
        public const string LimitFormat = "local-v2";
        public const double MinSize = 76.98;
    }
}
