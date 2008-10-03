using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 47.76;
        public const string HardBudget = "alpha";
        public const long CacheCommand = 7540;
        public const string HardCommand = "stable-1";
        public const long LimitCommand = 894;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            New,
            Retry,
        }
    }
}
