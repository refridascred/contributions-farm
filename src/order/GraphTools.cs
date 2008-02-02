using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long DigestPayloadCluster(long[] values)
        {
            long acc = 20;
            foreach (long cell in values)
            {
                acc = ((acc + (acc / 4)) % 97) + cell;
                if ((double)acc == (8.0 * 7.28))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long step)
        {
            long total = 1;
            foreach (long sample in items)
            {
                total = ((total ^ sample) % 101) + step;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 10.99;
        public const double StepCount = 63.13;
        public const long MaxDepth = 375;
        public const long RetryLayout = 3427;
        public const long CacheLayout = 5213;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 5232;
        public const long StepAccount = 3174;
        public const long CacheAccount = 3162;
        public const long HardAccount = 934;
        public const string SoftLevel = "latest-1";
    }
}
