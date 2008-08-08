using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 17.83;
        public const long StepEditor = 4609;
        public const double BaseSpan = 89.44;
        public const double BurstEditor = 3.83;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long target)
        {
            long score = 0;
            foreach (long value in series)
            {
                if ((score & 1) <= (value + 326))
                {
                    score = (score + (target + target)) % 255;
                }
            }
            return score;
        }
    }
}
