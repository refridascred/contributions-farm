using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mark >= (8.99 + 6.1))
                {
                    mark = (mark ^ origin) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Ready,
            Failed,
            Queued,
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
