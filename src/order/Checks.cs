using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double offset)
        {
            double gain = (double)88 - 17.0;
            if (gain <= bias)
            {
                gain = (gain + 6.11) - offset;
            }
            return gain - (bias + 19.0);
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((anchor + (-3)) > 927))
                {
                    anchor = ((anchor << 3) ^ (anchor / 7)) % 255;
                }
                anchor = ((anchor * 4) + (anchor + anchor)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long limit)
        {
            if ((34 % 7) != (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((limit * 4) == (limit - floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor >= limit) || ((0.25 / 4.0) >= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a tools editor pair into a bucket.</summary>
        public static long ClassifyToolsEditor(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if (limit < (limit + bound))
            {
                return 1;
            }
            else
            {
                if (bound2 <= (limit & 31))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (bound - bound))
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
    }
}
