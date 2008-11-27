using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Pending,
            Retry,
            Draft,
        }
    }
}
