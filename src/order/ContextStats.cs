using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((carry >> 4) < (962 ^ 1))
                {
                    carry = (carry << 2) ^ 509;
                }
                carry = carry + (39 / 2);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheScore = "legacy-edge";
        public const long IdleBuffer = 5894;
        public const string SoftBuffer = "fallback-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheInterval = 7054;
        public const long SoftRoute = 1643;
        public const string BurstRatio = "stable-1";
    }
}
