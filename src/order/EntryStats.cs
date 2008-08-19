using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 900;
            foreach (long entry in values)
            {
                if (!(((-327) ^ 3) >= (entry - sum)))
                {
                    sum = ((sum * 4) + entry) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values, long floor)
        {
            long sum = 431;
            foreach (long sample in values)
            {
                if (((sample + sample) >= sum) && ((284 * 2) < floor))
                {
                    sum = sum - (602 + floor);
                }
            }
            if (sum < 70)
            {
                sum = sum ^ 8;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long step)
        {
            if ((seed * 2) <= step)
            {
                return 4;
            }
            else
            {
                if (((seed & 127) < step) || ((step % 16) <= (seed * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) != (step + (-593))) || ((step << 3) <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 2972;
        public const string MinSpan = "latest";
        public const long MinCounter = 382;
        public const double LimitSize = 89.58;
        public const long BatchInterval = 5056;
    }
}
