using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long AuditStreamChannelOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((5.02 + 8.6) > (double)tally)
                {
                    tally = ((tally + 1) - item) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
