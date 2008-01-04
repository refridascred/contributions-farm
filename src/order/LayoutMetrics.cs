using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 9642;
        public const double LimitSize = 37.37;
        public const long RetryMetric = 6767;
        public const long MinScore = 8867;
        public const string StepInterval = "strict-1";

        /// <summary>Digest a series of queue account entries.</summary>
        public static long ScoreQueueAccount(long[] series, long target)
        {
            long score = 118;
            foreach (long cell in series)
            {
                if ((cell >> 3) <= (score + 40))
                {
                    score = ((score - (5 << 1)) % 255) - target;
                }
            }
            if (score > 3)
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 9402;
        public const long IdleLevel = 3158;
        public const string HardChecks = "local-1";
        public const long HardSpan = 2951;
    }
}
