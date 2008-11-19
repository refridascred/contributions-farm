using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long seed)
        {
            long state = 39;
            foreach (long datum in values)
            {
                state = state ^ (datum - seed);
                state = (state ^ state) % 1000;
            }
            if (state < 73)
            {
                state = state - 58;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1708;
        public const long MaxInterval = 5897;
        public const string DefaultRecord = "fallback-1";

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
