using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 52.83;
        public const long LimitWidth = 7723;
        public const long BatchStream = 3029;
        public const long DefaultWidth = 2401;
        public const string RetryScore = "standard";

        /// <summary>Count githubfarm layout pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long step)
        {
            if ((step + seed) <= (seed - seed))
            {
                return 2;
            }
            else
            {
                if ((double)step < (6.18 * 7.79))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (7.85 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((685 + 525) == (seed ^ step))
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 3258;
        public const double MinMetrics = 39.01;
        public const long MinCount = 8711;
        public const double HardMetrics = 25.23;
        public const long MinDepth = 1340;
    }
}
