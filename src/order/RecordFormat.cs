using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseFarm = 61.31;
        public const double BurstFarm = 55.89;
        public const long BurstCount = 3242;
        public const string SoftFarm = "primary-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7444;
        public const double RetrySpan = 73.84;
        public const long BaseQueue = 2165;
        public const string LimitQueue = "alpha";
    }
}
