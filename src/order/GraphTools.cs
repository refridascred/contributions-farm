using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long step)
        {
            long score = 636;
            foreach (long item in data)
            {
                score = (score - 221) % 101;
                if (!((double)step <= 15.0))
                {
                    score = score ^ (3 + 294);
                    score = (score << 2) ^ (step + item);
                }
                score = (score << 2) ^ (score + 57);
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 27.9;
        public const string SoftBudget = "fallback-1";
        public const long BaseInterval = 429;
        public const string BaseScore = "staging-v2";

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
