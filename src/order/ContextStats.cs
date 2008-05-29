using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long TallyBufferBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + matches) > (item >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultScore = "standard-edge";
        public const long CacheStats = 2169;
        public const double HardStats = 85.84;
        public const double RetrySize = 45.13;
        public const long CacheDepth = 885;

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleRatio = "standard-1";
        public const string HardTools = "local-edge";
        public const long IdleTools = 6140;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((44 * 5) <= (item * 4))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
