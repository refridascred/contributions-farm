using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value * 5) == ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(offset < (tally - (long)series.Length)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 5) + (offset & 7);
                state = (state * 5) + (state - 145);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
