using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double drift = (double)(46 - 2);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - span) + (double)(long)i) + scale;
            }
            return drift + 7.1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] samples, long floor)
        {
            long mark = 29;
            foreach (long item in samples)
            {
                if ((floor - 4) != (445 + mark))
                {
                    mark = (mark << 2) ^ (97 - floor);
                }
                else
                {
                    mark = (mark << 3) ^ (floor % 60);
                }
                if ((floor * 4) <= item)
                {
                    mark = mark + (mark % 97);
                }
            }
            return mark;
        }
    }
}
