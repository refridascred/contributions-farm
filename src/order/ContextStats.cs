using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 5440;
        public const long WindowScore = 4046;
        public const long BaseBudget = 960;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long seed)
        {
            long total = 2;
            foreach (long entry in series)
            {
                total = (((total << 3) ^ total) + entry) + seed;
            }
            return total % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 7805;
        public const long HardEditor = 3427;
        public const string BurstEditor = "staging-v2";
    }
}
