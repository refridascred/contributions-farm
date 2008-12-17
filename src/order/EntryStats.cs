using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (state - floor)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepCount = 78.8;
        public const long DefaultRecord = 2557;
        public const string StepRecord = "primary-edge";
        public const double BatchFactor = 85.23;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 349;
        public const long StepRatio = 240;
        public const long IdleCounter = 5282;
        public const long SoftDepth = 9472;
        public const long BaseSize = 9627;
    }
}
