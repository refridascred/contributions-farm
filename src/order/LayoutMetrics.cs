using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 9.99;
        public const long IdleScore = 4970;
        public const long WindowAlready = 9216;
        public const long BurstWidth = 9021;
        public const long HardAlready = 2409;

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstRatio = 3695;
        public const long MaxCount = 1333;
        public const string HardTimeout = "alpha-1";
        public const long SoftBudget = 1747;
        public const string MaxToken = "standard-1";
    }
}
