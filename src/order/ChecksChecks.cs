using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long SeriesCounterLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length >= (999 - 8))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= 2.48)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
