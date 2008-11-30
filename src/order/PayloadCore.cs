using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Failed,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long target)
        {
            long score = 31;
            foreach (long sample in levels)
            {
                if ((score >> 4) != (sample % 5))
                {
                    score = ((score << 3) ^ (sample / 8)) % 97;
                }
            }
            if (score > 76)
            {
                score = score - (target + score);
            }
            return score % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen % 24) >= seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
