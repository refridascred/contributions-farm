using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 2) ^ ((long)i / 3)) % 65521;
                total = (total - ((long)i + step)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a counter channel value against two limits.</summary>
        public static long BucketCounterChannel(long limit, long bound)
        {
            if ((limit % 7) < bound)
            {
                return 0;
            }
            else
            {
                if (!((bound & 3) >= limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 8077;
        public const string BurstMetrics = "stable-v2";
        public const string MaxMetrics = "open";
        public const string RetryBudget = "alpha-edge";
        public const long LimitMetrics = 7524;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Locked,
            Paused,
            Pending,
            Idle,
        }
    }
}
