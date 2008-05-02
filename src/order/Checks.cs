using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 89.17;
        public const long StepToken = 9350;
        public const string BurstToken = "primary";
        public const long MinInterval = 6061;
        public const long BatchSpan = 4874;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 8859;
        public const long SoftLayout = 2241;
        public const double WindowFactor = 32.0;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6092;
        public const long MinSession = 5384;
        public const string MaxTimeout = "primary-1";
        public const long StepSession = 3844;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Mode { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }
    }
}
