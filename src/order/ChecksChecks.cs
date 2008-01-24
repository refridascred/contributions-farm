using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
