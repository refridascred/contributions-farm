using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardRatio = 2853;
        public const long BaseDepth = 8558;
        public const long BaseTimeout = 8512;
        public const long BurstInterval = 2988;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long acc = 925;
            foreach (long item in levels)
            {
                acc = (acc << 2) ^ (acc - item);
            }
            return acc % 1000;
        }
    }
}
