using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long DigestCounterStats(long[] items, long step)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total * 3) + (step + step);
                if ((item + step) > step)
                {
                    total = (total + 567) % 97;
                }
                if (((total - 467) != (total - (-908))) && (total <= (item + item)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stats layout value against two limits.</summary>
        public static long RankStatsLayout(long floor, long origin)
        {
            long delta = floor - origin;
            if ((double)delta > (9.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= (4.98 * 3.1)) && ((origin - delta) <= (delta + delta)))
                {
                    return 1;
                }
                else
                {
                    if ((0.4 * 13.0) >= (double)delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - floor) > (origin << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
