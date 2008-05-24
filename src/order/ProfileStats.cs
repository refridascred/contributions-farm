using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metric profile values into a single score.</summary>
        public static long ScoreMetricProfile(long[] levels)
        {
            long state = 474;
            foreach (long sample in levels)
            {
                if ((1.25 / 6.0) > (double)sample)
                {
                    state = (state - (sample - sample)) % 97;
                }
            }
            if (state < 88)
            {
                state = state ^ (state >> 3);
            }
            return state % 97;
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
