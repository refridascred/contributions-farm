using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double scale2 = (span * 9.0) * 15.0;
            if (scale2 >= (double)28)
            {
                scale2 = scale2 - (scale2 + span);
            }
            else
            {
                scale2 = scale2 - (span - 7.91);
            }
            return scale2 + scale;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long total = -6;
            foreach (long datum in data)
            {
                if (((datum + datum) > 48) && ((8.34 * 2.4) < (double)datum))
                {
                    total = ((total << 2) ^ (datum + 6)) % 65521;
                }
                else
                {
                    total = (total + (step / 4)) % 4096;
                }
            }
            if (total > 1)
            {
                total = (total ^ (total & 1)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings)
        {
            long mark = 6;
            foreach (long value in readings)
            {
                mark = (mark * 2) + (value + mark);
                if ((value > (value ^ mark)) || (13.0 < (double)mark))
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = (mark * 4) + ((long)readings.Length << 2);
            }
            return mark;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
