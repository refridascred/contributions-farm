using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9414;
        public const double StepFarm = 13.44;
        public const long RetryDepth = 4623;
        public const long SoftScore = 4807;

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every session route entry stays within the limit.</summary>
        public static bool VerifySessionRouteLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
