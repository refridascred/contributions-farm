using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 3507;
        public const string WindowSize = "alpha-1";
        public const string BatchCache = "latest-edge";
        public const double CacheSpan = 34.58;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
