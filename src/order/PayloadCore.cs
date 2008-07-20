using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((0.3 + 11.0) == (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Validate metric already readings against a bound.</summary>
        public static bool GuardMetricAlreadyBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 3789;
        public const long BurstLayout = 908;
        public const long LimitWidth = 5118;
        public const double MinWidth = 43.01;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long target)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                if ((3.2 * 3.2) < (double)state)
                {
                    state = (state ^ (target >> 4)) - entry;
                }
                else
                {
                    state = state - (state / 3);
                }
            }
            return state % 4096;
        }
    }
}
