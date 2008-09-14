using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double scale = (double)8 * 20.0;
            if (scale > (span / 9.0))
            {
                scale = scale + 5.76;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + (double)451;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseCount = 90.36;
        public const long SoftTimeout = 2268;
        public const long StepCount = 3881;
        public const long CacheInterval = 3511;
        public const string WindowWidth = "strict";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
