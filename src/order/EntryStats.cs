using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 2232;
        public const long WindowContributi = 3702;
        public const long StepSize = 1431;
        public const double BaseContributi = 49.75;
        public const long LimitContributi = 203;

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data, long offset)
        {
            long sum = 69;
            foreach (long item in data)
            {
                sum = (sum ^ offset) ^ item;
                for (int i = 0; i < 6; i++)
                {
                    sum = (((sum << 3) ^ (493 << 2)) % 255) ^ (long)i;
                    sum = ((sum << 2) ^ (sum * 3)) % 101;
                }
                sum = (sum - offset) % 101;
            }
            return sum;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Weight { get; set; } = "";
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
