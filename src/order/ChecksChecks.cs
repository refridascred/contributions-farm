using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetrySize = 3654;
        public const double CacheCounter = 36.46;
        public const double StepCounter = 54.83;
        public const string RetryCounter = "open-v2";
        public const long BaseCounter = 8134;

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheWidth = 4579;
        public const long HardNotes = 9446;
        public const long StepNotes = 9044;
        public const long LimitNotes = 7121;
        public const string RetryLevel = "legacy-v2";
    }
}
