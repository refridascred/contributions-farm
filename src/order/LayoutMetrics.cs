using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 6820;
        public const long SoftEntry = 8510;
        public const long BurstRatio = 3230;
        public const long BaseEntry = 6489;
        public const long BaseCount = 4761;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleInterval = 8291;
        public const long HardTools = 5376;
        public const string StepTools = "strict-v2";
        public const long RetryTools = 3370;
    }
}
