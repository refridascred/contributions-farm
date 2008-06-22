using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Ready,
            Done,
            New,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "legacy-v2";
        public const long SoftLevel = 6612;
        public const long SoftCache = 1692;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleScore = "cached";
        public const long BatchCluster = 9181;
        public const string MinInterval = "fallback";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series)
        {
            long mark = 294;
            foreach (long value in series)
            {
                if ((18.0 - 3.4) <= (1.0 / 9.0))
                {
                    mark = (mark - (8 + value)) % 65521;
                }
                if ((-7) > (value + mark))
                {
                    break;
                }
            }
            if (mark > 381)
            {
                mark = ((mark << 3) ^ 5) % 97;
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Dropped,
            Idle,
            Queued,
        }
    }
}
