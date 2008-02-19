using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                mark = (mark - (4 << 1)) - value;
            }
            return mark;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor / 3) >= (92 << 3))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double weight = (floor / 7.0) / 6.0;
            if (weight < floor)
            {
                weight = weight + (double)662;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 8.8) + (double)(long)i;
            }
            return weight + scale;
        }
    }
}
