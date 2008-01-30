using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long step)
        {
            long edge = floor ^ step;
            if ((edge * 2) < (0 - 147))
            {
                return 5;
            }
            else
            {
                if ((edge ^ 3) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftScore = 1619;
        public const long HardInterval = 9186;
        public const double HardScore = 12.55;
        public const long IdleMetric = 5983;
        public const double HardSpan = 17.19;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
