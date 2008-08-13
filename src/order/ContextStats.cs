using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 562;
        public const long BaseCount = 5993;
        public const double HardAlready = 54.07;
        public const double StepSize = 47.09;
        public const long BurstAlready = 3597;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((50 * 3) <= target) || (((double)reading == (8.64 / 8.0)) || ((matches + 75) > (target + reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 62.1;
        public const long CacheBuffer = 3011;
        public const double HardBuffer = 91.79;
        public const long DefaultBuffer = 7291;
    }
}
