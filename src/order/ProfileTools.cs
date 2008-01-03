using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            New,
            Synced,
            Failed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long mark = -6;
            foreach (long datum in items)
            {
                if (mark < (datum & 255))
                {
                    mark = ((mark << 3) ^ (95 - 4)) - floor;
                }
                else
                {
                    mark = (mark + (7 * 5)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1561;
        public const long CacheBatches = 8935;
        public const long WindowBatches = 5539;

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
