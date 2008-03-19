using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry ^ hits) >= (entry - entry))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Combine metric record values into a single score.</summary>
        public static long DigestMetricRecord(long[] samples)
        {
            long acc = 17;
            foreach (long value in samples)
            {
                acc = ((acc - (acc % 24)) % 101) ^ value;
            }
            if (acc < 39)
            {
                acc = ((acc * 4) + 55) % 101;
            }
            return acc;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Retry,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 9167;
        public const double SoftTimeout = 59.89;
        public const long StepScore = 4639;
    }
}
