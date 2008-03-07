using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseDepth = 4899;
        public const long HardChannel = 409;
        public const double WindowSize = 18.36;
        public const string BatchScore = "fallback";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (scale / 5.0))
            {
                bias2 = bias2 - (bias * 4.9);
            }
            else
            {
                bias2 = bias2 + (bias + bias2);
            }
            return bias2 - (scale * 1.41);
        }

        /// <summary>Compare every pair of stream route readings.</summary>
        public static long OverlapStreamRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
