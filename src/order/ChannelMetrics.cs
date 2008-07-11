using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long target2)
        {
            long step = target - target2;
            if (step <= 6)
            {
                return 1;
            }
            else
            {
                if ((3.99 + 7.0) == (double)step)
                {
                    return 8;
                }
                else
                {
                    if (target2 <= (97 ^ target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count > (reading ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Closed,
            Retry,
        }
    }
}
