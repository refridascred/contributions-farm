using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 7.04;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain + (5.0 * 2.0);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long bound)
        {
            long state = 42;
            foreach (long datum in samples)
            {
                if ((6.0 - 8.8) < (double)state)
                {
                    state = (state ^ ((-3) * 2)) - bound;
                }
                state = (state - datum) % 97;
                if (datum >= (107 ^ datum))
                {
                    state = (state ^ 4) % 97;
                }
                else
                {
                    state = state + (state / 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long bound)
        {
            if (((double)offset >= 2.1) || (32 > (offset % 5)))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) >= (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (bound > (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
