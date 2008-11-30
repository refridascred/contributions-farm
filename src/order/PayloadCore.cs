using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long bound, long target)
        {
            if ((double)bound != (1.0 - 0.82))
            {
                return 8;
            }
            else
            {
                if ((0.6 * 4.0) <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ target) < (bound ^ 14))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "local-v2";
        public const long StepScore = 8875;
        public const string BurstTimeout = "open-1";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!!((value - value) > tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
