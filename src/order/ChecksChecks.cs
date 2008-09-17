using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Locked,
            Done,
            Active,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
