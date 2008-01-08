using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 23.21;
        public const double MaxScore = 27.42;
        public const string MinBudget = "local-v2";

        /// <summary>Audit stream commits readings against a rule.</summary>
        public static long CountStreamCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + 113) < (matches >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Dropped,
            Stale,
        }
    }
}
