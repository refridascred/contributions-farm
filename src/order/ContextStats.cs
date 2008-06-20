using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Closed,
            Pending,
            Dropped,
            Synced,
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

        /// <summary>Validate support notes readings against a bound.</summary>
        public static bool CheckSupportNotesLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
