using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 41.14;
        public const string BaseProfile = "cached";
        public const double BurstWidth = 43.12;
        public const long CacheLevel = 6211;
        public const double CacheRatio = 1.4;
    }
}
