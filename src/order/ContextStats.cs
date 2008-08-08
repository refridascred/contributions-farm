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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((3 + count) < (count % 97))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
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

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Synced,
            Closed,
            Pending,
        }
    }
}
