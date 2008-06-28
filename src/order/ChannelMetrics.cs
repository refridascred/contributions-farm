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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long origin)
        {
            long slot = offset ^ origin;
            if (((offset - 31) > (offset % 10)) && ((origin >> 2) > (slot / 9)))
            {
                return 7;
            }
            else
            {
                if ((slot * 5) >= (75 - slot))
                {
                    return 5;
                }
                else
                {
                    if ((origin - slot) > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0.9 + 9.3) != (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
