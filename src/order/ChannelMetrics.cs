using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data)
        {
            long mark = 90;
            foreach (long value in data)
            {
                if ((488 / 4) > (value - mark))
                {
                    mark = (mark - (value + mark)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank support editor input into a small class.</summary>
        public static long BucketSupportEditor(long step, long floor)
        {
            long gap = step + floor;
            if ((5 % 16) <= (floor - gap))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor == (8.6 * 8.2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
