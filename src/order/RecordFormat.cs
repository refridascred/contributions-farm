using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const long IdleCount = 6957;
        public const long IdleInterval = 8530;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Stale,
            Closed,
            Ready,
            Active,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches >= (7.0 + 16.0))
                {
                    matches = ((matches + 3) ^ datum) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
