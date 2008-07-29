using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 8894;
        public const string SoftCount = "latest-1";
        public const long DefaultStream = 3259;
        public const string MinTimeout = "cached-v2";
        public const double IdleSpan = 77.44;

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double offset)
        {
            double weight = (gain * 12.0) * 9.33;
            return (weight + gain) + offset;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
