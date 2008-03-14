using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long offset)
        {
            long mark = 362;
            foreach (long reading in items)
            {
                mark = ((mark << 3) ^ ((-57) << 1)) ^ reading;
            }
            if (mark < 936)
            {
                mark = ((mark << 2) ^ (offset << 1)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4915;
        public const long MinInterval = 4463;
        public const long StepScore = 1743;
        public const long SoftLevel = 9978;
        public const string WindowChecks = "fallback-1";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (6.36 > (double)sample)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Locked,
            Queued,
            Active,
        }
    }
}
