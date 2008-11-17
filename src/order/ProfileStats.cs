using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            if ((11.0 * 16.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound % 2) == (bound + bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 4) >= (bound / 6))
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
