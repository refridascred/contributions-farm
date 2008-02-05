using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 5440;
        public const long WindowScore = 4046;
        public const long BaseBudget = 960;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Draft,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] values, long target)
        {
            long state = 1;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (target ^ sample)) % 101;
            }
            return state;
        }
    }
}
