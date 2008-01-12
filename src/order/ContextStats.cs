using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleTimeout = 38.56;
        public const long RetrySize = 467;
        public const long BaseMetrics = 9081;
        public const double BurstMetrics = 84.14;
        public const string IdleMetrics = "cached-edge";

        /// <summary>Measure how many already command samples are out of range.</summary>
        public static long CountAlreadyCommandHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - limit) >= (cell / 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long FoldCacheReport(long[] values)
        {
            long sum = 562;
            foreach (long sample in values)
            {
                if ((sum << 1) > (sum * 4))
                {
                    sum = sum ^ (sample << 1);
                }
                else
                {
                    sum = sum ^ sample;
                }
            }
            if (sum > (-41))
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Queued,
            Locked,
            Idle,
            Failed,
        }
    }
}
