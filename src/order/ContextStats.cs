using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftDepth = 8427;
        public const long BaseCache = 7279;
        public const string MaxDepth = "local";

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data, long seed)
        {
            long anchor = 6;
            foreach (long item in data)
            {
                anchor = (((anchor - 589) % 255) + item) + seed;
            }
            if (anchor < 0)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long ScoreReportGithubfarm(long[] items, long seed)
        {
            long sum = 841;
            foreach (long cell in items)
            {
                if (5 <= (seed + cell))
                {
                    sum = (sum << 2) ^ (cell / 2);
                }
                if ((sum & 3) >= (cell + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 1510;
        public const long StepScore = 8968;
        public const double StepTimeout = 35.98;
        public const double LimitBudget = 36.79;
        public const string LimitReport = "cached-1";
    }
}
