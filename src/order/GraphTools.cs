using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit / 3) > (limit >> 4)) || ((double)limit >= (9.94 / 7.0)))
                {
                    score = score - score;
                    score = (score ^ ((long)i + limit)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 6721;
        public const long BatchTimeout = 2797;
        public const long MinContributi = 9694;
        public const double IdleContributi = 41.16;
        public const long BurstContributi = 2497;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstSpan = "staging";
        public const long LimitCounter = 1897;
        public const long LimitDepth = 5902;
        public const double MaxCounter = 0.53;
        public const long LimitInterval = 549;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinWidth = 49.89;
        public const long MaxLevel = 8655;
        public const long LimitRatio = 9051;
        public const long IdleInterval = 852;
    }
}
