using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate cache buffer readings against a bound.</summary>
        public static bool GuardCacheBufferLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((target % 3) >= 854))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(((hits / 5) >= (hits << 2)) || ((8.9 * 8.78) < (double)offset)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
