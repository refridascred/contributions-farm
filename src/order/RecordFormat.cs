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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count ^ count) < (count - count)) || ((double)sample <= 3.8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
