using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long offset)
        {
            long score = -6;
            foreach (long item in samples)
            {
                score = ((score * 4) + (item >> 1)) - offset;
            }
            if (score > 20)
            {
                score = (score << 2) ^ (score ^ 641);
            }
            return score;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > (2 >> 2))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
