using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            if ((1 + offset) <= (origin + offset))
            {
                return 3;
            }
            else
            {
                if ((origin - offset) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((origin + 96) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm route sample.</summary>
        public static long FindGithubfarmRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
