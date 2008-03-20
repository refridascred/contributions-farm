using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items, long origin)
        {
            long total = 975;
            foreach (long item in items)
            {
                total = (((total * 3) + (0 + total)) + item) + origin;
                if ((double)total != (4.0 / 2.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long SeekBatchStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item + item) >= (count - count)) || (count >= item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
