using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long floor)
        {
            if ((bound >= floor) || ((922 - 613) < (bound << 3)))
            {
                return 2;
            }
            else
            {
                if ((6.0 * 8.3) == (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (((double)floor <= (5.2 + 7.35)) && (floor < (9 ^ 41)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Idle,
            Pending,
            Paused,
        }
    }
}
