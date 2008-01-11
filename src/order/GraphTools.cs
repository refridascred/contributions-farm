using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double floor)
        {
            double load = (bias + floor) / 5.0;
            if (load > (double)906)
            {
                load = load - 20.0;
            }
            return load - (double)28;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series, long step)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                anchor = (anchor ^ (item >> 4)) % 65521;
                if (((double)step != (double)item) || ((step - anchor) <= item))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 3) + (97 & 31)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "alpha";
        public const string DefaultRecord = "legacy";
        public const long BurstBudget = 489;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
