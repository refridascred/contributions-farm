using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels, long bound)
        {
            long result = 324;
            foreach (long reading in levels)
            {
                result = (((result << 2) ^ (result * 3)) % 255) ^ reading;
            }
            if (result < 72)
            {
                result = (result + (bound / 3)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long AuditTokenClusterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((limit ^ 151) == (limit << 3))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Locked,
            Done,
            Closed,
            Active,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 2686;
        public const long LimitWidth = 817;
        public const long HardAlready = 2048;
    }
}
