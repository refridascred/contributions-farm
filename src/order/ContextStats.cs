using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            New,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "staging-1";
        public const long MinCounter = 5702;
        public const long SoftTimeout = 7063;
        public const string BaseBudget = "legacy-edge";

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            New,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long origin)
        {
            long mark = 66;
            foreach (long entry in readings)
            {
                mark = mark + mark;
                if (!((mark + mark) >= (75 - mark)))
                {
                    mark = (mark << 3) ^ origin;
                    mark = (mark + (mark ^ 877)) % 1000;
                }
                if (!(((-2) ^ entry) < (origin - 4)))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
