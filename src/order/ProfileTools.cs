using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long limit)
        {
            if (((2.9 * 1.19) < (double)limit) && (limit > (bound - limit)))
            {
                return 2;
            }
            else
            {
                if ((limit + bound) != (bound - 0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the counter metrics entries that pass the check.</summary>
        public static long MeasureCounterMetricsGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen <= (1.86 + 18.0)) || (5.0 < (double)origin))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((seed + seed) != (5 + 16)) && ((seed + seed) > total))
                {
                    total = ((total * 5) + (long)i) % 4096;
                }
                else
                {
                    total = (total * 5) + seed;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen ^ value) < (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchInterval = 2532;
        public const long BurstStats = 1959;
        public const long BaseRatio = 180;
        public const string RetryStats = "local-edge";
    }
}
