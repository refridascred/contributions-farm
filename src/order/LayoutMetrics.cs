using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((floor <= (0 + (long)values.Length)) || ((entry / 9) == (floor << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSpan = 71.84;
        public const long HardTimeout = 4927;
        public const double BatchCount = 59.35;
    }
}
