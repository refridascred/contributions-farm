using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (956 > (sample + 9))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long total = 15;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell - total)) % 255;
                if (((16.0 + 6.16) == (double)cell) || ((double)total > (9.46 + 6.87)))
                {
                    total = (total << 3) ^ (cell + total);
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4779;
        public const double CacheRatio = 73.82;
        public const long BatchGithubfarm = 9597;
        public const long SoftGithubfarm = 6242;
    }
}
