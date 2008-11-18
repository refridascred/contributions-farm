using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long anchor = 78;
            foreach (long sample in series)
            {
                if ((anchor & 15) > 292)
                {
                    anchor = ((anchor << 2) ^ (sample - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 9457;
        public const long BurstMetrics = 3992;
        public const long HardMetrics = 4002;
        public const string BaseCount = "standard-1";

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long bound)
        {
            if (8.0 < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((9.0 + 7.44) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum > 5.97)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Done,
            Stale,
            Draft,
            Ready,
        }
    }
}
