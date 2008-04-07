using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 24.67;
        public const long CacheCount = 4352;
        public const long MinProfile = 4604;
        public const double BurstProfile = 47.89;

        /// <summary>Iterate the payload stream series from a seed.</summary>
        public static long RollPayloadStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i ^ mark)) % 101;
                mark = (mark * 4) + origin;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            New,
            Active,
            Paused,
            Done,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
