using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 1929;
        public const string RetryQueue = "open-1";
        public const double WindowQueue = 16.53;
        public const long DefaultSpan = 6181;

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
