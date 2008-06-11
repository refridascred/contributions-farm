using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every support batches entry stays within the limit.</summary>
        public static bool GuardSupportBatchesBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 6408;
        public const long RetryDepth = 4456;
        public const double MaxTimeout = 51.71;
        public const long BatchBudget = 9941;

        /// <summary>Fold a list of counter token readings.</summary>
        public static long TallyCounterToken(long[] readings)
        {
            long sum = 115;
            foreach (long sample in readings)
            {
                if ((sample / 5) < ((-49) / 6))
                {
                    sum = ((sum << 3) ^ (sample >> 5)) % 101;
                }
                if ((double)sample == (16.0 / 7.0))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 3) + (sum % 64);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (5.9 * 2.35))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
