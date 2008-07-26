using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Closed,
            Retry,
            Paused,
            Draft,
            New,
        }
    }
}
