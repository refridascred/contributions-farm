using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long MeasureAccountEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry ^ entry) != (entry - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 7) < (value + hits))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long offset2)
        {
            if (offset > (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((7.14 + 9.6) != (double)offset2)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
