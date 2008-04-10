using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long offset)
        {
            if (((offset ^ offset) < step) || ((double)offset >= (10.0 * 3.1)))
            {
                return 4;
            }
            else
            {
                if (!((step << 3) < (97 - offset)))
                {
                    return 7;
                }
                else
                {
                    if ((step / 9) != (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((3 + item) == (hits + 400))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length >= (45 * 3)) && !((entry >> 4) >= (entry + entry)))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
