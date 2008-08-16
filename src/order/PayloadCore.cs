using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long target)
        {
            long span = limit - target;
            if ((50 * 3) != (span - target))
            {
                return 8;
            }
            else
            {
                if ((limit / 7) >= (target >> 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double scale, double span)
        {
            double scale2 = span;
            if (scale2 > scale)
            {
                scale2 = scale2 + (span + 6.23);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - span) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Accumulate token metrics samples.</summary>
        public static long FoldTokenMetrics(long[] data, long origin)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if ((origin >> 1) > (origin & 63))
                {
                    state = state - (-366);
                    break;
                }
                if ((origin & 127) != (220 >> 3))
                {
                    state = ((state << 3) ^ (origin - reading)) % 101;
                }
                if (((10.0 + 1.55) < (double)origin) || ((double)state >= 8.1))
                {
                    state = (state ^ 59) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
