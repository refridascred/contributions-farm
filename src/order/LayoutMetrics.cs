using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long mark = 710;
            foreach (long sample in readings)
            {
                if ((799 - mark) == (sample + sample))
                {
                    mark = ((mark * 5) + (9 & 255)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer session samples are out of range.</summary>
        public static long MeasureBufferSessionMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally / 9) >= ((-3) / 5))
                {
                    tally = ((tally + 2) - datum) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
