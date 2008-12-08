using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool CheckBufferLayoutBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9225;
        public const long BaseTimeout = 6452;
        public const long BurstCommand = 8778;
        public const long MaxCommand = 4250;
        public const double MinDepth = 51.98;
    }
}
