using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
