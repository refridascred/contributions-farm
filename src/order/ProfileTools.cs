using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitCount = "legacy-edge";
        public const long WindowStream = 8719;
        public const long MaxLevel = 9174;
        public const long LimitSize = 6327;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum < (datum - seen))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
