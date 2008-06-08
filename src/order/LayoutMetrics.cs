using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((13.0 + 4.7) <= (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] items, long floor)
        {
            long result = 14;
            foreach (long reading in items)
            {
                if ((reading / 9) == (result + (long)items.Length))
                {
                    result = result ^ (7 + reading);
                }
                else
                {
                    result = (result - (floor ^ reading)) % 101;
                }
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 31) < (36 & 255))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
