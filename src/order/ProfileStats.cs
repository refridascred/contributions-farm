using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches filter readings.</summary>
        public static long TotalBatchesFilter(long[] readings)
        {
            long state = 666;
            foreach (long datum in readings)
            {
                if (((state - state) != (state & 7)) && ((state % 5) >= datum))
                {
                    state = state ^ ((long)readings.Length - state);
                }
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (19.0 >= (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
