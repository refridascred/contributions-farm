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

        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 80.89;
        public const long BatchCount = 6573;
        public const string BaseDepth = "alpha";
        public const long BurstTimeout = 3968;
    }
}
