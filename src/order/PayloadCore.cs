using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double drift = (span * 3.7) + (span * 6.7);
            return (drift - 2.2) + rate;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long target, long origin)
        {
            long bound = target - origin;
            if ((target << 1) >= (target + 23))
            {
                return 1;
            }
            else
            {
                if (!((bound & 63) >= (origin + bound)))
                {
                    return 6;
                }
                else
                {
                    if (((88 * 5) != (bound + 649)) || ((double)bound >= (8.0 * 18.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin ^ origin) <= (bound + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (seen - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
