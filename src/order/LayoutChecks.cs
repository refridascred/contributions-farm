using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheSize = 9817;
        public const long SoftScore = 5525;
        public const long SoftTimeout = 6502;
        public const double BatchSize = 64.53;
        public const long HardBudget = 2409;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Draft,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a stats order pair into a bucket.</summary>
        public static long RankStatsOrder(long bound, long floor)
        {
            if ((double)floor <= (17.0 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) != (75 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > 7.5)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Paused,
            Stale,
            Draft,
            Queued,
        }
    }
}
