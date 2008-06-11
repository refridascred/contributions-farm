using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
