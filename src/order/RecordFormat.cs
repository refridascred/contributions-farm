using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Pending,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "standard-1";
        public const string HardReport = "staging-v2";
        public const long RetryInterval = 5699;
        public const double BatchDepth = 89.31;
        public const long WindowLevel = 3192;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
