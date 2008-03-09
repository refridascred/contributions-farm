using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks buffer reading by value.</summary>
        public static long LookupChecksBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 41) == (69 << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first queue counter entry that matches the target.</summary>
        public static long LookupQueueCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long sum = 5;
            foreach (long item in items)
            {
                if ((sum * 4) < (item - item))
                {
                    sum = ((sum << 2) ^ item) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
