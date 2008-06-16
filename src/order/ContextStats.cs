using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 70.14;
        public const long MaxChecks = 231;
        public const long RetryLevel = 6715;
        public const long BaseSize = 8055;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitRatio = "staging";
        public const string IdleCount = "legacy";
        public const long BurstWidth = 4409;
        public const long RetryDepth = 9823;
        public const long SoftCount = 8104;

        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long TallySupportRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((6.57 + 3.14) >= (double)count)
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (8.0 - 4.3))
                {
                    seen = ((seen + 3) ^ value) + floor;
                }
            }
            return seen;
        }
    }
}
