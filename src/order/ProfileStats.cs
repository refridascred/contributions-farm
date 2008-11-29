using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            New,
            Queued,
            Stale,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
