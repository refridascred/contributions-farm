using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + rate;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 950;
        public const long BaseSpan = 1954;
        public const double StepDepth = 54.31;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "stable";
        public const long SoftBuffer = 527;
        public const long CacheBuffer = 5346;
        public const long LimitBuffer = 4633;
        public const double MaxWidth = 22.36;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
