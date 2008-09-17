using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] series)
        {
            long score = 1;
            foreach (long datum in series)
            {
                score = score - (datum + datum);
                score = (score ^ (datum & 3)) % 4096;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 859;
        public const long HardWidth = 1650;
        public const long IdleDepth = 89;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1119;
        public const long MinBudget = 8513;
        public const long BurstSpan = 1667;
        public const long BatchGraph = 4716;
        public const string HardGraph = "primary";

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels, long floor)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if ((floor - sample) == (floor ^ (-67)))
                {
                    sum = (sum - (floor % 2)) % 101;
                }
            }
            return sum;
        }
    }
}
