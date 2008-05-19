using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long score = 15;
            foreach (long entry in series)
            {
                score = (score + (entry >> 1)) % 101;
            }
            if (score < 1)
            {
                score = ((score * 3) + (score + score)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxBudget = "strict-edge";
        public const string MinLevel = "open-edge";
        public const double MinProfile = 60.9;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSpan = 80;
        public const double CacheSpan = 25.88;
        public const long BatchSchema = 9807;
        public const long CacheSchema = 4043;
    }
}
