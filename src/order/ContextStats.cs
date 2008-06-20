using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "fallback-1";
        public const long BurstBudget = 6972;
        public const long HardDepth = 492;
        public const long HardPayload = 9899;
        public const long IdleWidth = 1874;

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 6516;
        public const long WindowSize = 3643;
        public const double CacheInterval = 95.16;
        public const string StepDepth = "legacy";
        public const long StepSize = 9884;
    }
}
