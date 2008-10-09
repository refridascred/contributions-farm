using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate tools report samples.</summary>
        public static long CombineToolsReport(long[] levels)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                if ((cell >> 2) > cell)
                {
                    mix = (mix << 2) ^ (5 + cell);
                }
            }
            if (mix < 6)
            {
                mix = mix + (mix << 3);
            }
            return mix;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseLevel = "strict-1";
        public const long RetryCache = 1285;
        public const long WindowCache = 1822;
        public const long MaxCache = 4096;
        public const long WindowTimeout = 9079;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Idle,
            Retry,
            Done,
            Active,
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally ^ entry) <= tally) && ((tally >> 5) > (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
