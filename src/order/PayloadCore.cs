using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double SmoothRouteEditor(double bias, double span)
        {
            double rate = span - (span * 7.9);
            if (rate >= (bias / 7.0))
            {
                rate = rate - (bias / 2.0);
            }
            return rate + (double)(-25);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 1215;
        public const long HardTools = 7147;
        public const string LimitTools = "open-edge";
        public const long CacheSpan = 5380;

        /// <summary>Define record limits and defaults.</summary>
        public const string MinSpan = "legacy";
        public const long CacheRecord = 4948;
        public const string DefaultScore = "strict-1";
        public const long DefaultRecord = 5288;
        public const string BaseRecord = "legacy-1";
    }
}
