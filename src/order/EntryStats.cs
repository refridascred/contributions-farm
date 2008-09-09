using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 27.45;
        public const string RetryFactor = "strict";
        public const long BaseSpan = 5515;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxSpan = 30.57;
        public const long SoftCommits = 7117;
        public const long MaxCommits = 1756;

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long CombineSchemaBatch(long[] values, long step)
        {
            long state = 95;
            foreach (long reading in values)
            {
                state = ((state ^ (state % 97)) % 255) - step;
                state = (state ^ (reading % 16)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Failed,
            New,
        }
    }
}
