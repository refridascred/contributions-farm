using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((limit <= ((long)readings.Length ^ 35)) && ((tally >> 5) > (value >> 2))) && (tally > (value ^ limit)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Retry,
            Dropped,
            Synced,
        }
    }
}
