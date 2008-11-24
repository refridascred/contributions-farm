using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 24.72;
        public const long BurstBudget = 2508;
        public const string HardBuffer = "staging-v2";
        public const double BatchBuffer = 98.19;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8223;
        public const long MaxLevel = 1333;
        public const long BatchDepth = 437;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(item >= (bound - 822)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
