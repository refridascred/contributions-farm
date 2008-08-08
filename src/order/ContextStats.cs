using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload queue entry stays within the limit.</summary>
        public static bool GuardPayloadQueueLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool VerifyPayloadRecordBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
