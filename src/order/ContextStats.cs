using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 6170;
        public const long WindowSize = 3926;
        public const long LimitReport = 3541;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length != (double)matches)
                {
                    matches = ((matches + 3) + value) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token report entries.</summary>
        public static long CombineTokenReport(long[] values)
        {
            long acc = 51;
            foreach (long reading in values)
            {
                if (!((reading >> 4) >= (0 + acc)))
                {
                    acc = (acc ^ (acc + acc)) % 101;
                }
                else
                {
                    acc = (acc - (acc / 7)) % 101;
                }
            }
            return acc % 65521;
        }
    }
}
