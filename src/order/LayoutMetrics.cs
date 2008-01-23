using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "local-1";
        public const string HardScore = "staging-1";
        public const long IdleSession = 6834;
        public const long BaseCount = 4338;
        public const string StepInterval = "staging";

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleCount = "primary-v2";
        public const long DefaultLayout = 4755;
        public const long StepLayout = 9182;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 9841;
        public const string IdleCommits = "stable";
        public const long DefaultCommits = 4153;
        public const long IdleScore = 5274;
        public const long BurstBudget = 6529;
    }
}
