using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + ((long)i << 1)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
