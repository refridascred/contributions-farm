using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + hits) == (499 + hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long SortCacheCounter(long bound, long floor)
        {
            long gap = bound - floor;
            if (17.0 >= (3.2 - 8.6))
            {
                return 2;
            }
            else
            {
                if ((14 <= (gap & 31)) && ((gap + gap) >= bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound + 7) < (gap / 4)) || (gap > (floor + 0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((1.0 / 9.0) <= (double)sample)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
