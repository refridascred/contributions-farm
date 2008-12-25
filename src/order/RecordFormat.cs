using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheDepth = 8.62;
        public const long WindowMetrics = 3674;
        public const long MaxMetrics = 3076;

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchBudget = "alpha-v2";
        public const long BurstFormat = 6865;
        public const string WindowCount = "fallback-edge";
        public const string BaseSpan = "stable-edge";
    }
}
