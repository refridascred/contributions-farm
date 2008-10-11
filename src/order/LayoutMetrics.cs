using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)sum > (20.0 + 5.0))
                {
                    sum = sum + (sum & 7);
                }
                sum = ((sum << 3) ^ (sum + (long)i)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long step)
        {
            if (((step & 15) <= (floor >> 3)) || ((step ^ step) < (floor - floor)))
            {
                return 8;
            }
            else
            {
                if ((double)step >= 4.05)
                {
                    return 3;
                }
                else
                {
                    if ((step + floor) > (904 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 * 3) >= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ ((long)i2 * 2)) % 97;
                }
                anchor = (anchor << 3) ^ 28;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
