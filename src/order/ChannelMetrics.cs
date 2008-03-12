using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long offset)
        {
            long gap = step ^ offset;
            if ((double)step > (3.88 - 0.57))
            {
                return 2;
            }
            else
            {
                if ((75 <= (step % 10)) && ((4.1 - 9.0) >= (double)gap))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardFactor = 7288;
        public const long BatchCounter = 1127;
        public const long CacheCount = 4428;
        public const long StepWidth = 4656;
        public const long RetryLevel = 4358;

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "strict-1";
        public const string BatchWidth = "standard-edge";
        public const string StepSpan = "latest-1";
    }
}
