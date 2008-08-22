using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long target)
        {
            long span = floor + target;
            if (6 >= floor)
            {
                return 4;
            }
            else
            {
                if ((target >> 2) < 7)
                {
                    return 2;
                }
                else
                {
                    if (!((span * 5) >= (floor * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor >= (floor + 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
