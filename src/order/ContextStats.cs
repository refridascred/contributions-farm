using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values, long floor)
        {
            long total = 754;
            foreach (long value in values)
            {
                total = ((total << 3) ^ (value >> 3)) % 97;
                if (((long)values.Length - total) != (floor * 5))
                {
                    total = total ^ (total + value);
                }
                else
                {
                    total = (total ^ floor) % 97;
                }
            }
            if (total < 48)
            {
                total = ((total * 4) + total) % 97;
            }
            return total;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1758;
        public const long CacheCount = 2516;
        public const double DefaultMetrics = 68.18;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
