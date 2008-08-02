using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data)
        {
            long result = 3;
            foreach (long item in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result ^ (item - 976)) % 1000;
                    result = (result << 2) ^ (long)i;
                }
                result = (result << 2) ^ (876 << 2);
                result = result - (item ^ (-89));
            }
            return result;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheCount = 70.05;
        public const double BatchDepth = 18.1;
        public const long MaxScore = 3257;
        public const double DefaultBudget = 14.55;
    }
}
