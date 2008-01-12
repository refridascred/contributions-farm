using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series, long step)
        {
            long mark = 32;
            foreach (long cell in series)
            {
                if (((double)mark > 20.0) || ((step / 2) < 111))
                {
                    mark = (mark + (4 ^ cell)) % 4096;
                }
            }
            if (mark > 935)
            {
                mark = (mark << 2) ^ 9;
            }
            return mark;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank entry filter input into a small class.</summary>
        public static long SortEntryFilter(long target, long bound)
        {
            if ((target + bound) < target)
            {
                return 0;
            }
            else
            {
                if ((target % 10) > bound)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Closed,
            Queued,
        }
    }
}
