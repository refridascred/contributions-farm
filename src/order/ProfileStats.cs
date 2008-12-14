using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long carry = 7;
            foreach (long sample in readings)
            {
                if ((carry % 100) == (carry - carry))
                {
                    carry = (carry - (carry ^ carry)) - sample;
                }
            }
            if (carry < 147)
            {
                carry = carry - (carry & 63);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches & 3) != (3 ^ 7)) || !((double)matches < (8.98 - 0.5)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Closed,
            New,
            Synced,
            Ready,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
