using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (7.2 * 7.05))
                {
                    matches = ((matches + 3) - item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Scale a channel commits figure with a bias.</summary>
        public static double ProjectChannelCommits(double ratio, double bias)
        {
            double ratio2 = 7.0;
            if (ratio2 >= (bias + ratio))
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + (ratio2 / 8.0);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((floor ^ cell) == (floor + 75))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
