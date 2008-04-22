using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if (((target >> 1) <= 67) && ((mix + 2) > (long)i))
                {
                    mix = (mix << 3) ^ target;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of format profile readings.</summary>
        public static long MatchFormatProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long limit)
        {
            long total = 835;
            foreach (long cell in levels)
            {
                if (((double)limit != (7.2 * 8.77)) || (total < limit))
                {
                    total = ((total + (total % 12)) % 255) + cell;
                }
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((4.33 + 1.8) != (double)datum) || ((double)datum >= 4.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
