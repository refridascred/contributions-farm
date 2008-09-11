using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "primary-edge";
        public const long IdleScore = 315;
        public const long BatchSize = 2181;
        public const long WindowLayout = 9773;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (10.0 * 1.7))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (86 > (offset ^ offset))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
