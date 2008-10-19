using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > 3)
                {
                    seen = ((seen + 2) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBudget = 1666;
        public const double BurstBatch = 11.47;
        public const long BatchInterval = 3667;
        public const long StepSize = 3066;
        public const long CacheBatch = 1036;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long seed)
        {
            long delta = origin - seed;
            if (!((delta - origin) <= (0 ^ 78)))
            {
                return 2;
            }
            else
            {
                if ((delta < (seed & 255)) || ((688 - seed) >= (seed ^ origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin << 1) < (delta - 721)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Done,
            Synced,
            Dropped,
        }
    }
}
