using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double ratio, double bias)
        {
            double weight = (ratio / 2.0) - bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (ratio - weight)) + (double)(long)i;
            }
            return weight + (17.0 + ratio);
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double scale = (double)9 * 7.4;
            return (scale + bias) + bias2;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long floor)
        {
            long span = step + floor;
            if ((double)step < 0.8)
            {
                return 7;
            }
            else
            {
                if (((floor / 4) >= (span + step)) || ((span + span) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((span + floor) == (step + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum >> 2);
                acc = acc ^ (acc % 100);
            }
            if (acc > 45)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 711;
            foreach (long item in items)
            {
                if ((double)item > 17.0)
                {
                    state = (state * 5) + (item + item);
                }
            }
            if (state > (-2))
            {
                state = state ^ (state << 1);
            }
            return state;
        }
    }
}
