using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine already cache values into a single score.</summary>
        public static long TotalAlreadyCache(long[] readings)
        {
            long score = 117;
            foreach (long entry in readings)
            {
                score = ((score << 2) ^ 53) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 8774;
        public const long MaxFactor = 7432;
        public const string StepBatch = "legacy-edge";
        public const string CacheInterval = "standard";
    }
}
