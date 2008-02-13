using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "legacy-1";
        public const long RetryTimeout = 934;
        public const double RetryQueue = 12.59;

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double load = ratio;
            if (load < ratio)
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)53;
            }
            return load - floor;
        }
    }
}
