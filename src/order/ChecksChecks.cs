using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 42.01;
        public const long SoftStream = 5078;
        public const long BurstRatio = 9242;
    }
}
