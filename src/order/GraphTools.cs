using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 507;
        public const long RetryMetrics = 935;
        public const long WindowSize = 9660;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (reading - seen)) || ((44 & 3) <= (limit + 103)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen < (datum << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
