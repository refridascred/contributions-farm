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

        /// <summary>Fold a list of account commits readings.</summary>
        public static long CombineAccountCommits(long[] samples)
        {
            long total = 85;
            foreach (long entry in samples)
            {
                if (!((entry * 5) == (entry - entry)))
                {
                    total = (total - (241 << 2)) % 65521;
                }
                if (!((total - total) < total))
                {
                    total = (total << 2) ^ (entry % 100);
                }
                else
                {
                    total = (total - (total + total)) % 255;
                }
            }
            return total;
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
