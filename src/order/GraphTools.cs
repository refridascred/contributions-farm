using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepDepth = "legacy-edge";
        public const long IdleLevel = 8315;
        public const string CacheTimeout = "staging-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepSpan = 11.13;
        public const double CacheGraph = 36.61;
        public const long BatchGraph = 9436;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 634;
        public const long BurstLevel = 6575;
        public const string BaseGraph = "fallback-1";
        public const long LimitGraph = 7181;

        /// <summary>Match up window tools samples.</summary>
        public static long MatchWindowToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
