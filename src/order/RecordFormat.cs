using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long target)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((5.77 * 15.0) < (double)target)
                {
                    anchor = (((anchor * 3) + anchor) % 1000) ^ entry;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ 3) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Idle,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a queue support sample.</summary>
        public static long LookupQueueSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
