using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Locked,
            Done,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 835;
        public const double HardTimeout = 17.35;
        public const double DefaultLevel = 45.27;
        public const string HardLevel = "latest";
        public const long LimitQueue = 283;
    }
}
