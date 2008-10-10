using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
