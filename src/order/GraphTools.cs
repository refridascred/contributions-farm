using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinFactor = 31.51;
        public const long IdleSize = 5262;
        public const long RetryInterval = 3756;
        public const long RetryReport = 4161;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 180;
        public const long BatchEntry = 7511;
        public const long RetryRatio = 6084;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 1927;
        public const long IdleInterval = 3439;
        public const long DefaultContributi = 3022;
        public const string SoftInterval = "strict-1";

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8799;
        public const long MaxWidth = 3459;
        public const long MinWidth = 352;
        public const long SoftWidth = 8989;
    }
}
