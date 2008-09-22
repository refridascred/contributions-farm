using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (8 > sample)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
