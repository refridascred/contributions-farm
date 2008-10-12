using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            New,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1064;
        public const long HardScore = 4178;
        public const long MinEditor = 4706;
        public const string BurstEditor = "open-v2";
        public const long RetryEditor = 573;

        /// <summary>Classify a order checks pair into a bucket.</summary>
        public static long RankOrderChecks(long step, long step2)
        {
            if ((step2 & 7) == (step2 - step2))
            {
                return 8;
            }
            else
            {
                if (!((double)step == (double)35))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
