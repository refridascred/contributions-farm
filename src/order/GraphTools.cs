using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the githubfarm support entries that pass the check.</summary>
        public static long AuditGithubfarmSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample % 12) <= (sample % 10))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long bound)
        {
            if (((seed / 2) > (bound - seed)) && ((351 + bound) != (bound & 1)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) >= (bound << 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                if ((0.46 / 9.0) >= (double)mark)
                {
                    mark = ((mark * 4) + mark) ^ value;
                }
            }
            if (mark < 8)
            {
                mark = (mark + (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Limit { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
