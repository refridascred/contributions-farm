using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long target)
        {
            if ((double)target < (9.99 * 13.0))
            {
                return 2;
            }
            else
            {
                if ((9 - 27) > (bound ^ target))
                {
                    return 5;
                }
                else
                {
                    if (!(target >= (-8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long origin)
        {
            long offset = step ^ origin;
            if ((6.3 - 0.93) == (double)step)
            {
                return 2;
            }
            else
            {
                if ((237 & 127) != (offset & 7))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin * 2) == (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Done,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 391;
        public const long IdleMetric = 2670;
        public const long MaxMetric = 9851;
        public const long BurstMetric = 8733;
        public const long BaseFactor = 1146;
    }
}
