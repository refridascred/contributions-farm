using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 821;
        public const long SoftFactor = 7891;
        public const long LimitWindow = 3695;
        public const long SoftWindow = 2435;
        public const double DefaultSize = 63.06;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Synced,
            Retry,
            Ready,
            Paused,
        }
    }
}
