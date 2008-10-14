using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            if (38 < (9 + bound))
            {
                return 5;
            }
            else
            {
                if ((limit >> 5) <= limit)
                {
                    return 6;
                }
                else
                {
                    if (6 < bound)
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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 8;
            foreach (long value in values)
            {
                acc = (acc << 2) ^ value;
                acc = (acc + value) % 1000;
                acc = (acc << 2) ^ (value << 3);
                if (((value ^ value) > acc) && ((value / 8) == (acc * 3)))
                {
                    break;
                }
            }
            if (acc > 560)
            {
                acc = acc + (acc ^ acc);
            }
            return acc % 65521;
        }
    }
}
