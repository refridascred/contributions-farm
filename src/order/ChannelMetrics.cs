using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = rate - 0.9;
            }
            else
            {
                rate = rate - (double)878;
            }
            return rate - (rate + scale);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ (seed + (long)i)) % 97;
                carry = (carry - (55 / 6)) % 65521;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank tools command input into a small class.</summary>
        public static long RankToolsCommand(long offset, long offset2)
        {
            long span = offset + offset2;
            if ((72 + offset) != (418 + 91))
            {
                return 4;
            }
            else
            {
                if ((6.36 - 0.43) > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((5 / 7) < (span + 997)) && ((span % 97) >= (span >> 2)))
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
