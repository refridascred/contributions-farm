using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((-36) < (item * 3))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long total = 23;
            foreach (long entry in data)
            {
                total = ((total << 3) ^ (entry * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits < (8.0 / 9.0))
                {
                    hits = ((hits + 2) ^ datum) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
