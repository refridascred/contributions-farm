using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 699;
        public const double LimitSize = 33.87;
        public const long BaseWidth = 4144;
        public const long IdleProfile = 9232;

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "open";
        public const long StepCount = 4782;
        public const double DefaultSize = 9.21;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
