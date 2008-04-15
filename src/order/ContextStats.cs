using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 536;
        public const string HardSize = "cached";
        public const double RetryBudget = 85.29;
        public const long StepSchema = 3881;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long offset)
        {
            if ((1 - offset) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor - offset) < (offset - offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
