using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheTimeout = "fallback-v2";
        public const long IdleInterval = 2982;
        public const string StepCommits = "latest";

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardLevel = 5108;
        public const double HardSize = 18.28;
        public const string WindowRecord = "primary-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 6006;
        public const long HardWidth = 2426;
        public const double BurstLayout = 41.36;
    }
}
