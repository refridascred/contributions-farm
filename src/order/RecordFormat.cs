using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 4571;
        public const long BatchCount = 4151;
        public const string BatchContributi = "stable-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 1681;
        public const string DefaultStream = "alpha-edge";
        public const double MaxStream = 78.72;
        public const string BurstStream = "open-v2";
        public const double CacheStream = 52.74;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + (long)i2) % 97;
                    total = ((total * 2) + (total + total)) % 255;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
