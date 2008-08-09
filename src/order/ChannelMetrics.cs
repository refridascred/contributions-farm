using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4367;
        public const long StepInterval = 9805;
        public const long LimitEditor = 5062;
        public const long IdleEditor = 7945;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((43 % 60) >= (845 - bound))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long score = 49;
            foreach (long entry in samples)
            {
                score = (score ^ 9) + entry;
            }
            if (score < 76)
            {
                score = (score + score) % 1000;
            }
            return score;
        }
    }
}
