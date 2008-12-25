using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheDepth = 8.62;
        public const long WindowMetrics = 3674;
        public const long MaxMetrics = 3076;

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchBudget = "alpha-v2";
        public const long BurstFormat = 6865;
        public const string WindowCount = "fallback-edge";
        public const string BaseSpan = "stable-edge";
    }
}
