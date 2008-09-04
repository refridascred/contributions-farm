using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (36 < (floor & 63))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Dropped,
            New,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Done,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long bound, long limit)
        {
            if ((limit - limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (!((bound / 2) > (4 + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((1.8 * 4.61) <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((595 * 5) > (limit + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every profile batch entry stays within the limit.</summary>
        public static bool GuardProfileBatchBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
