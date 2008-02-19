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

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
