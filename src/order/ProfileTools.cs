using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 2.95;
        public const long MaxFactor = 8160;
        public const string RetryStream = "primary-edge";
        public const long WindowStream = 4107;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "cached-v2";
        public const string SoftRatio = "latest";
        public const long BatchCount = 1195;
        public const double SoftDepth = 17.33;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
