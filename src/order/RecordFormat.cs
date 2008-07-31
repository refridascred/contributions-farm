using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 53.07;
        public const long IdleReport = 134;
        public const string BaseRatio = "stable";
        public const long HardReport = 3350;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 2) ^ state) % 255;
                if ((state * 2) < (0 - 0))
                {
                    state = state ^ bound;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }
    }
}
