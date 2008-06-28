using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long bound)
        {
            long bound2 = offset - bound;
            if (((bound2 + (-3)) >= bound2) && (offset < (offset + bound)))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 2) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 3) > (offset / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool CheckMetricsChannelBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
