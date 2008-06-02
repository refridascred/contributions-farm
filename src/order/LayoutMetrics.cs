using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (tally & 15))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long seed)
        {
            long delta = bound + seed;
            if (delta <= bound)
            {
                return 2;
            }
            else
            {
                if ((delta >= (seed << 2)) || ((bound & 255) <= (seed * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the token record series from a seed.</summary>
        public static long DeriveTokenRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i >> 5) < ((long)i ^ 0)) && ((double)step <= 4.15))
                {
                    continue;
                }
                else
                {
                    carry = carry - ((long)i / 5);
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
