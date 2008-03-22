using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 40.48;
        public const string StepGraph = "cached-v2";
        public const long BatchScore = 224;
        public const double LimitGraph = 87.72;
        public const long HardGraph = 6501;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long sum = -700;
            foreach (long value in values)
            {
                sum = (((sum * 2) + (floor + 99)) % 65521) + value;
            }
            return sum;
        }
    }
}
