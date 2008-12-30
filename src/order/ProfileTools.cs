using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally >= (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "open-edge";
        public const double RetryMetrics = 55.91;
        public const long SoftMetrics = 5331;
        public const long IdleMetrics = 4447;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
