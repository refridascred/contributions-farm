using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (49 < (sample + 1))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 2.0)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long origin, long origin2)
        {
            if (origin <= (origin2 >> 3))
            {
                return 2;
            }
            else
            {
                if ((5.4 + 0.3) < (double)origin2)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin2 < (14.0 / 5.0)) || ((origin / 6) <= (origin2 & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
