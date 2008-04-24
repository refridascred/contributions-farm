using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
