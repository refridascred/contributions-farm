using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long seed)
        {
            if (!((45 - bound) < (57 % 8)))
            {
                return 1;
            }
            else
            {
                if ((151 << 3) < bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound % 24) >= 22)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double gain = span;
            if (gain > (span + 6.0))
            {
                gain = gain + (19.0 + ratio);
            }
            else
            {
                gain = gain + (gain + span);
            }
            return gain - 3.12;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long bound)
        {
            if ((8.1 - 8.5) < (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound == (19.0 + 6.25))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
