using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepInterval = 3895;
        public const long RetryChecks = 5490;
        public const double MinWidth = 48.62;
        public const long HardSize = 9116;
        public const long CacheDepth = 2439;

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long origin)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if ((double)cell == (double)origin)
                {
                    total = (total + (origin + origin)) % 65521;
                }
            }
            if (total < 898)
            {
                total = ((total * 4) + origin) % 65521;
            }
            return total % 97;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count % 10) <= (count >> 4))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count <= (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
