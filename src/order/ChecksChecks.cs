using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
