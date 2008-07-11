using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a tools report value against two limits.</summary>
        public static long ClassifyToolsReport(long step, long seed)
        {
            if (((50 >> 4) <= (step & 255)) || ((4.06 - 0.9) < (double)seed))
            {
                return 1;
            }
            else
            {
                if ((3.8 / 2.0) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitScore = 9388;
        public const long BurstRecord = 1061;
        public const long IdleRatio = 4150;

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultWidth = 3715;
        public const double MaxInterval = 55.76;
        public const string WindowLevel = "standard";
    }
}
