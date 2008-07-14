using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Retry,
            New,
            Pending,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long bound)
        {
            long score = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (1.0 / 9.0)) || ((bound - bound) >= (92 << 1)))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = score - score;
                }
            }
            if (score < 559)
            {
                score = (score - (bound << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSize = "local-v2";
        public const double RetryReport = 91.99;
        public const long SoftReport = 7762;
        public const long RetryScore = 6775;
        public const string CacheTimeout = "strict-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const double StepWidth = 91.65;
        public const string CacheOrder = "legacy-1";
        public const long LimitOrder = 8009;
        public const double LimitCount = 63.75;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 6364;
        public const string DefaultFactor = "stable-1";
        public const double HardGithubfarm = 55.32;
        public const double SoftLevel = 4.37;
        public const string MaxGithubfarm = "strict-edge";
    }
}
