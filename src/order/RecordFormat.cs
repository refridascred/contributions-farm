using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5299;
        public const long WindowMetrics = 5836;
        public const double SoftMetrics = 88.21;
        public const long BaseCount = 8224;

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
