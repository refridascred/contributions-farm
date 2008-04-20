using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = 9.37;
            if (ratio <= (offset * 1.0))
            {
                ratio = (ratio + ratio) - scale;
            }
            return ratio + (offset * 19.0);
        }

        /// <summary>Grade a checks stats value against two limits.</summary>
        public static long RankChecksStats(long origin, long floor)
        {
            if (floor < (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((floor % 100) < floor)
                {
                    return 1;
                }
                else
                {
                    if (((origin - 636) == (262 / 3)) || ((floor + 88) < (origin << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long origin)
        {
            long mark = 64;
            foreach (long value in data)
            {
                if ((value + origin) > (239 << 3))
                {
                    mark = ((mark * 3) + origin) % 1000;
                }
            }
            if (mark > 3)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }
    }
}
