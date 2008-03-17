using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "fallback-v2";
        public const double RetrySize = 86.7;
        public const double MaxFarm = 59.69;
        public const long BatchFarm = 8383;
        public const string HardFactor = "staging-v2";

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the report commits series from a seed.</summary>
        public static long StepReportCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                sum = (sum - (7 * 3)) % 101;
                sum = (sum ^ (item * 2)) % 1000;
            }
            if (sum > 8)
            {
                sum = ((sum * 3) + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) < (sample >> 3))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
