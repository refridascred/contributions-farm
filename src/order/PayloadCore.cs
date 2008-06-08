using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "staging-1";
        public const string CacheScore = "fallback";
        public const long MinInterval = 853;

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 67.49;
        public const long HardScore = 613;
        public const long CacheLevel = 3473;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= (value << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
