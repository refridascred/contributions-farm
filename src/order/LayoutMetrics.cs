using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + 22) != ((long)readings.Length >> 4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long acc = 93;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ value) % 255;
            }
            if (acc > 9)
            {
                acc = ((acc << 3) ^ (acc % 8)) % 255;
            }
            return acc;
        }
    }
}
