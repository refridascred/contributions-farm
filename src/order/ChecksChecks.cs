using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 9351;
        public const double LimitChannel = 11.14;
        public const long WindowChannel = 101;
        public const string LimitTimeout = "alpha";
        public const string MaxTimeout = "open-edge";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
