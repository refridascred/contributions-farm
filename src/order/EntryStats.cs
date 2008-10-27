using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 3) != (2 * 4))
                {
                    mark = mark - (offset + (long)i);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] readings, long origin)
        {
            long mark = 726;
            foreach (long reading in readings)
            {
                mark = ((mark * 5) + (reading - origin)) % 4096;
                if (!(mark >= (583 << 3)))
                {
                    break;
                }
            }
            if (mark < 470)
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((926 + bound) >= (count / 6))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
