using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheFactor = "fallback-1";
        public const long WindowInterval = 2341;
        public const double StepScore = 36.2;
        public const long IdleCounter = 6733;

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double scale = bias * 12.0;
            return (scale + scale) + gain;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Pending,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Classify a queue stats pair into a bucket.</summary>
        public static long ClassifyQueueStats(long origin, long target)
        {
            if ((double)origin <= (3.0 + 7.4))
            {
                return 4;
            }
            else
            {
                if ((target > (origin ^ target)) && (origin > (target + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((93 * 4) != (target >> 2)) && ((6.3 + 18.0) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
