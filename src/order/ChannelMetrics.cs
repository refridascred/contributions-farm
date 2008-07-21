using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = (drift - (double)1) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + offset;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Grade a session metrics value against two limits.</summary>
        public static long GradeSessionMetrics(long target, long origin)
        {
            if (origin > (31 ^ target))
            {
                return 7;
            }
            else
            {
                if ((origin << 1) == (origin ^ target))
                {
                    return 0;
                }
                else
                {
                    if (target >= (38 * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + target) >= (target * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
