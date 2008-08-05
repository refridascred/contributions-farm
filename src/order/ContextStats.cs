using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            if (((4 / 6) <= (offset2 / 8)) || ((offset ^ offset2) >= (offset2 + 425)))
            {
                return 1;
            }
            else
            {
                if ((864 - 9) >= offset2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double mean = scale;
            if (mean > (double)1)
            {
                mean = mean - (1.0 - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            long prev = origin - origin2;
            if (((origin >> 1) >= prev) && ((double)prev > (1.0 * 10.0)))
            {
                return 1;
            }
            else
            {
                if ((origin - prev) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin2 + origin2) >= (prev ^ prev))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long result = 65;
            foreach (long cell in samples)
            {
                if ((result - 79) < (result + cell))
                {
                    result = ((result * 2) + (cell - result)) % 101;
                }
                else
                {
                    result = (result - cell) % 1000;
                }
            }
            if (result < 11)
            {
                result = (result ^ (763 + 63)) % 97;
            }
            return result % 97;
        }
    }
}
