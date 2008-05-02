using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 47.92;
        public const long BaseSpan = 1071;
        public const long BurstInterval = 8730;
        public const long WindowQueue = 4734;
        public const string LimitQueue = "latest-v2";

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length != (entry - 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "stable-1";
        public const long MaxGraph = 6246;
        public const double StepGraph = 15.94;
        public const long MinRatio = 5472;
        public const long WindowScore = 496;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
        }
    }
}
