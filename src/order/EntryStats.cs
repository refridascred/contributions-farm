using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit report checks readings against a rule.</summary>
        public static long CountReportChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum <= (tally >> 4))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultDepth = "alpha";
        public const string SoftCommand = "fallback-1";
        public const long SoftBudget = 4569;
        public const long LimitCommand = 2828;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long seed)
        {
            long offset = limit ^ seed;
            if (((offset + seed) == (seed ^ limit)) && ((double)seed > (double)2))
            {
                return 7;
            }
            else
            {
                if ((offset * 4) != (seed & 1))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 5) < (seed + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
