using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit session editor readings against a rule.</summary>
        public static long AuditSessionEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!!(origin > (origin >> 4)))
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long floor)
        {
            if ((offset + offset) >= (floor + 34))
            {
                return 2;
            }
            else
            {
                if ((9 - floor) > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (mix + 9);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long total = -7;
            foreach (long value in series)
            {
                total = ((total - (offset >> 3)) % 101) ^ value;
            }
            return total;
        }
    }
}
