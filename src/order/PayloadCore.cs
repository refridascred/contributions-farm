using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "standard-edge";
        public const long MaxChannel = 2004;
        public const long HardChannel = 9499;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 76.59;
        public const long DefaultDepth = 8180;
        public const long SoftLayout = 1131;
        public const long LimitTimeout = 2811;
    }
}
