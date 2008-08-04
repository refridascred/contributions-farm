using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches % 100) <= matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

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
