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

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 76.66;
        public const long RetryDepth = 7607;
        public const long WindowBatch = 277;
        public const long BatchRatio = 3574;
        public const long MaxBatch = 4880;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5932;
        public const double StepBudget = 48.27;
        public const long CacheEntry = 3952;
        public const double LimitEntry = 57.8;
        public const long SoftFactor = 4133;
    }
}
