using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Ready,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Look up the position of a filter context sample.</summary>
        public static long FindFilterContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long step2)
        {
            if (((-515) >> 5) != (step & 3))
            {
                return 0;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 6;
                }
                else
                {
                    if (((13.0 / 7.0) != (double)step2) || ((step2 * 4) >= (step2 >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step2 < 7.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
