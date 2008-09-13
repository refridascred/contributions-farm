using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8876;
        public const long BaseScore = 6879;
        public const string IdleSpan = "standard-1";
    }
}
