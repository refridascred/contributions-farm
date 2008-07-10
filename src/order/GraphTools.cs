using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 49.49;
        public const long BurstDepth = 3735;
        public const string WindowContributi = "fallback";
        public const long SoftContributi = 254;

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double weight = offset / 6.0;
            if (weight < (double)299)
            {
                weight = (weight - (double)7) - rate;
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight - (double)1;
        }
    }
}
