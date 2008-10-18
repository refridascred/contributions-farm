using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double bias = (gain / 3.0) + (offset + offset);
            if (bias <= bias)
            {
                bias = bias - (gain * 6.7);
            }
            else
            {
                bias = bias - offset;
            }
            return bias - bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 8164;
        public const long IdleWidth = 8505;
        public const long DefaultLevel = 628;
        public const double SoftTimeout = 40.7;
        public const double StepSize = 73.15;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
