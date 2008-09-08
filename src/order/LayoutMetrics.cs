using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long bound, long origin)
        {
            long bound2 = bound ^ origin;
            if (((bound % 7) > (7 % 12)) || ((origin ^ origin) != (bound ^ origin)))
            {
                return 6;
            }
            else
            {
                if (bound2 > (5 & 7))
                {
                    return 3;
                }
                else
                {
                    if (!(4 < (origin ^ origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double span)
        {
            double drift = (double)(2 & 1);
            return ((drift + drift) + rate) + span;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 49;
            foreach (long cell in readings)
            {
                if ((result % 2) != (result - cell))
                {
                    result = (result - (4 + cell)) % 97;
                }
            }
            return result;
        }
    }
}
