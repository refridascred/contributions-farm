using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double load = (double)(0 % 97);
            if (load < load)
            {
                load = (load - (load - 8.0)) + weight;
            }
            return load - bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "primary-edge";
        public const long RetryInterval = 7311;
        public const long LimitInterval = 6265;
        public const string CacheStats = "strict-1";
        public const long SoftLevel = 513;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
