using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (11.0 / 2.0))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) <= (cell * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

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
