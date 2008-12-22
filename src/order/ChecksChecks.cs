using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 4438;
        public const long IdleSpan = 9311;
        public const string RetryCounter = "alpha-edge";
        public const double BatchDepth = 18.52;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits * 4) >= (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first token account entry that matches the target.</summary>
        public static long SeekTokenAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
