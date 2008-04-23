using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardWidth = 3176;
        public const long BaseCount = 2437;
        public const long StepSupport = 7488;
        public const string MinRatio = "stable-edge";
        public const long DefaultTimeout = 2752;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed - carry) >= (carry - carry))
                {
                    carry = (carry * 5) + (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Failed,
            Paused,
            Ready,
        }
    }
}
