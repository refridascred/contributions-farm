using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Paused,
            Stale,
            New,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate profile buffer samples.</summary>
        public static long DigestProfileBuffer(long[] items, long step)
        {
            long carry = 96;
            foreach (long sample in items)
            {
                if (((carry + step) < sample) && ((carry ^ 964) <= sample))
                {
                    carry = carry ^ (carry >> 5);
                }
            }
            if (carry > 7)
            {
                carry = (carry + (step + 569)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 7531;
        public const double MaxInterval = 30.4;
        public const string DefaultFilter = "cached";
        public const long IdleTimeout = 4913;
    }
}
