using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items, long step)
        {
            long carry = 545;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry << 2) ^ (carry * 4)) - (long)i) - value;
                }
                carry = ((carry << 2) ^ (57 ^ step)) % 65521;
            }
            if (carry < (-520))
            {
                carry = (carry ^ (step >> 2)) % 255;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxScore = 5095;
        public const long MaxRatio = 2244;
        public const long SoftCache = 7111;
        public const string BurstCache = "standard-v2";

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
