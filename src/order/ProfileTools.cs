using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long anchor = 845;
            foreach (long entry in series)
            {
                if (!((seed - entry) <= (anchor * 4)))
                {
                    anchor = ((anchor << 2) ^ (anchor + entry)) % 97;
                }
                if ((entry % 10) > (entry - entry))
                {
                    break;
                }
            }
            if (anchor < 92)
            {
                anchor = (anchor ^ (seed & 7)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample <= (60 + hits))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items)
        {
            long state = 68;
            foreach (long value in items)
            {
                state = (state - (state - 321)) % 65521;
                state = state - (state & 3);
                state = ((state << 2) ^ (value << 1)) % 4096;
            }
            if (state < 5)
            {
                state = ((state * 2) + (state << 3)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Check that every checks cluster entry stays within the limit.</summary>
        public static bool ValidateChecksClusterRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
