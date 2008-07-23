using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long bound)
        {
            long slot = offset - bound;
            if (((offset * 5) > (slot & 7)) || ((double)bound < (double)31))
            {
                return 1;
            }
            else
            {
                if (((bound >> 3) != (bound >> 1)) && ((double)slot <= (9.6 - 5.08)))
                {
                    return 3;
                }
                else
                {
                    if (!((slot - offset) == (slot >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((9.0 * 20.0) < (double)tally))
                {
                    tally = ((tally + 3) + entry) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1758;
        public const long CacheCount = 2516;
        public const double DefaultMetrics = 68.18;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
