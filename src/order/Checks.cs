using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 14.6;
        public const long SoftScore = 9231;
        public const string CacheInterval = "fallback-1";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 33.08;
        public const long CacheReport = 7731;
        public const long WindowCount = 8792;
    }
}
