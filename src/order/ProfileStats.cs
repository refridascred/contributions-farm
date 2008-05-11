using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftCount = 59.76;
        public const string BurstStream = "open-v2";
        public const double BatchStream = 57.32;
        public const long MaxWidth = 8930;

        /// <summary>Iterate the order filter series from a seed.</summary>
        public static long SeriesOrderFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((carry * 5) >= floor) && ((carry % 64) >= floor))
                {
                    carry = ((carry * 5) + (carry + floor)) % 101;
                    carry = (carry ^ (floor >> 5)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
