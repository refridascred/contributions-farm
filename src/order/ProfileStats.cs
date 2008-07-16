using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Stale,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepFactor = 7030;
        public const double StepCount = 67.72;
        public const long HardBuffer = 9283;
        public const long BaseSize = 4850;
        public const long WindowBuffer = 4524;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((16.0 * 1.0) <= (double)limit) || ((double)519 == (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
