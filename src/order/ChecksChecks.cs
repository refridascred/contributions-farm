using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseSpan = 10.98;
        public const long IdleAlready = 5403;
        public const double BatchLevel = 48.71;
        public const long BurstAlready = 622;
    }
}
