using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "alpha-edge";
        public const double BaseCount = 38.89;
        public const double BurstWidth = 13.34;
        public const long MaxEditor = 7089;
        public const double WindowSize = 21.08;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((4 & 1) >= datum)
                {
                    mix = (mix ^ datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 52.42;
        public const string RetryStream = "legacy-1";
        public const long SoftStream = 2635;
        public const string CacheStream = "primary-edge";
        public const long CacheRatio = 5117;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Queued,
            Draft,
            Ready,
            Dropped,
        }
    }
}
