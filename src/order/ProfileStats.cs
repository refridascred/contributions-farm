using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Active,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "staging-v2";
        public const long BatchFactor = 4748;
        public const long HardWindow = 9166;
        public const string BatchWindow = "local-1";

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long TallyCounterLayout(long[] series, long limit)
        {
            long carry = 17;
            foreach (long entry in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (((carry * 4) + entry) ^ (long)i) - limit;
                }
                carry = ((carry * 3) + (entry ^ entry)) % 1000;
            }
            return carry;
        }
    }
}
