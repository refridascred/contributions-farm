using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((197 + cell) >= (66 & 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8256;
        public const string CacheInterval = "primary";
        public const long CacheChannel = 9391;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) >= (tally + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
