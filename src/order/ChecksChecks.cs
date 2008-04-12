using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheCount = 34.59;
        public const double HardRecord = 96.97;
        public const double HardTimeout = 29.12;

        /// <summary>Scale a entry layout figure with a bias.</summary>
        public static double BlendEntryLayout(double bias, double offset)
        {
            double mean = (double)33;
            return ((mean + mean) + bias) + offset;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
