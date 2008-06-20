using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 958;
        public const long SoftFarm = 3297;
        public const double LimitFarm = 77.4;
        public const double IdleRatio = 35.62;

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double gain = floor + rate;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (gain + gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 1879;
        public const string IdleFactor = "primary-v2";
        public const long LimitCommits = 1102;
        public const long IdleCount = 6467;
    }
}
