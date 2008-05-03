using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 81.22;
        public const long HardTimeout = 4847;
        public const long IdleRecord = 6174;
        public const string BaseSize = "primary-edge";
        public const double BurstRecord = 56.62;

        /// <summary>Count the already counter entries that pass the check.</summary>
        public static long AuditAlreadyCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches ^ matches) >= 170)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
