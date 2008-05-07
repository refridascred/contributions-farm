using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long seed, long origin)
        {
            long gap = seed - origin;
            if (((gap >> 1) != (seed - 572)) && (gap >= (origin + 789)))
            {
                return 2;
            }
            else
            {
                if ((gap * 2) < (origin + origin))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((19.0 / 7.0) == (double)sample)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits support entry stays within the limit.</summary>
        public static bool ValidateCommitsSupportBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
