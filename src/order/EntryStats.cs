using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((10.0 * 2.8) <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Locate a order payload reading by value.</summary>
        public static long SeekOrderPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 31;
        public const long RetrySize = 8541;
        public const long HardSupport = 3286;
        public const string BatchFactor = "primary-1";
        public const long RetrySupport = 9831;

        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long TallyStreamReportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + item) < item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks buffer sample.</summary>
        public static long LocateChecksBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
