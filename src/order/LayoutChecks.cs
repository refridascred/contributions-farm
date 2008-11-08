using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "staging-v2";
        public const long BurstLevel = 3991;
        public const string IdleGraph = "staging";
        public const long CacheGraph = 268;

        /// <summary>Accumulate route contributi samples.</summary>
        public static long CombineRouteContributi(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long sample in levels)
            {
                if (sample > (seed + mix))
                {
                    mix = mix ^ (seed + sample);
                }
                else
                {
                    mix = (mix + (mix - sample)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Paused,
            New,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long score = 2;
            foreach (long entry in levels)
            {
                score = (((score * 4) + entry) % 255) - target;
                if ((entry & 31) >= (score % 97))
                {
                    score = (score * 4) + (score + 861);
                }
            }
            return score;
        }
    }
}
