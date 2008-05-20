using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            New,
            Synced,
            Queued,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((7.19 + 18.0) == (double)matches) && (cell < matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 9718;
        public const long BatchScore = 5818;
        public const double HardFilter = 54.02;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstWidth = 76.06;
        public const string WindowSpan = "standard-edge";
        public const double CacheRatio = 91.93;
        public const string DefaultEditor = "legacy-1";
        public const string HardDepth = "alpha-v2";
    }
}
