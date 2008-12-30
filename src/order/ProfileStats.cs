using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double bias)
        {
            double drift = weight / 6.0;
            return drift + (bias + 2.1);
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long target, long offset)
        {
            if (38 <= (target + target))
            {
                return 2;
            }
            else
            {
                if ((target % 97) > (offset << 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double rate = (double)2 + (span - span);
            if (rate >= (span - span))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (double)6;
            }
            return rate - bias;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
