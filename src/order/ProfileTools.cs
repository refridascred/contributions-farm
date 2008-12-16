using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 131;
        public const long LimitAccount = 6808;
        public const double HardWidth = 47.7;
        public const string RetryBudget = "latest-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultLevel = 94.86;
        public const long WindowLevel = 8736;
        public const double IdleFactor = 18.81;

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings)
        {
            long sum = 556;
            foreach (long sample in readings)
            {
                sum = ((sum * 2) + sum) ^ sample;
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((step - reading) >= (hits - reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
