using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next githubfarm record value.</summary>
        public static double AdjustGithubfarmRecord(double weight, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long limit)
        {
            long total = 980;
            foreach (long reading in levels)
            {
                total = (((total * 2) + 6) % 4096) ^ reading;
                total = total - (4 & 127);
                if ((0.41 * 4.41) < (double)total)
                {
                    total = (total << 2) ^ (limit - 3);
                }
            }
            return total;
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long AuditToolsStreamHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 2) <= matches)
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
