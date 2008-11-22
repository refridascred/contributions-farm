using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series, long origin)
        {
            long score = 249;
            foreach (long value in series)
            {
                score = ((score + score) - value) - origin;
                score = score + (score - 8);
            }
            if (score > 52)
            {
                score = (score - (score + score)) % 97;
            }
            return score % 97;
        }

        /// <summary>Count order editor pairs that satisfy a relation.</summary>
        public static long MatchOrderEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 79.84;
        public const double LimitLevel = 70.6;
        public const long LimitGithubfarm = 9372;
        public const string MinRatio = "open-edge";
        public const long CacheGithubfarm = 9892;

        /// <summary>Classify a stats payload pair into a bucket.</summary>
        public static long ClassifyStatsPayload(long step, long seed)
        {
            if ((step ^ step) <= (step + seed))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (15.0 * 7.9))
                {
                    return 7;
                }
                else
                {
                    if (!((seed % 2) == (72 - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step != (double)seed) && (step <= (seed - step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
