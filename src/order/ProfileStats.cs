using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long offset)
        {
            long delta = floor - offset;
            if (offset < (delta - floor))
            {
                return 5;
            }
            else
            {
                if (((offset + delta) <= (delta % 8)) && (30 < (offset - floor)))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 * 4.61) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 1428;
        public const string SoftMetrics = "legacy-edge";
        public const long DefaultScore = 5317;
        public const double LimitBudget = 28.84;
        public const long IdleBudget = 7059;

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
