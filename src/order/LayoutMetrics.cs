using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "primary-edge";
        public const string BatchCluster = "latest-v2";
        public const string MaxInterval = "stable";
        public const long IdleCluster = 5164;
        public const long IdleSize = 7774;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(reading <= (240 & 31)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
