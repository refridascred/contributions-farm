using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double bias = 5.0 * 17.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - 6.0) + (double)(long)i) + rate) + offset;
            }
            return bias - bias;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheWidth = 54.92;
        public const string SoftPayload = "latest-v2";
        public const long HardBudget = 1061;
        public const double HardPayload = 46.96;
        public const long MinPayload = 5125;

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 1191;
        public const double WindowSpan = 10.73;
        public const double BaseNotes = 91.3;
        public const double RetryRatio = 44.51;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 89.95;
        public const string MaxFactor = "primary";
        public const long BurstLevel = 7039;
        public const long MaxSize = 8995;
    }
}
