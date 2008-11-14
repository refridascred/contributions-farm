using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the context profile entries that pass the check.</summary>
        public static long MeasureContextProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length >> 2) > matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long total = 187;
            foreach (long datum in series)
            {
                total = (total + (datum * 2)) % 4096;
                if (((datum >> 2) >= total) && ((total - datum) >= total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) != (offset + offset))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            if (((1.7 + 2.1) < (double)offset) && ((double)limit >= 1.8))
            {
                return 1;
            }
            else
            {
                if (limit <= (offset + 755))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
