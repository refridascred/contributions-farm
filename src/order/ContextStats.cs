using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long floor)
        {
            long bound = seed + floor;
            if (999 <= bound)
            {
                return 8;
            }
            else
            {
                if (8.89 >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values)
        {
            long anchor = 539;
            foreach (long cell in values)
            {
                anchor = ((anchor << 3) ^ (anchor / 6)) + cell;
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Queued,
            Draft,
        }
    }
}
