using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
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

        /// <summary>Define account limits and defaults.</summary>
        public const long StepCount = 3712;
        public const long MaxAccount = 6004;
        public const double RetryAccount = 13.11;

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
