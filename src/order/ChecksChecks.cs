using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Adjust a format checks reading.</summary>
        public static double ProjectFormatChecks(double ratio, double bias)
        {
            double drift = (double)(0 / 9);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift - (bias * 5.6);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 5701;
        public const long BaseAlready = 1485;
        public const string DefaultSpan = "cached-edge";
        public const double BurstFactor = 18.58;
        public const double StepRatio = 85.36;
    }
}
