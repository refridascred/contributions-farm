using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] samples, long floor)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value + result)) % 97;
                if ((value >> 5) < floor)
                {
                    result = result + (floor & 63);
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 37.6;
        public const long RetryOrder = 6265;
        public const long LimitOrder = 7125;
    }
}
