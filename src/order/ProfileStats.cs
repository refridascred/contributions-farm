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

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples, long target)
        {
            long total = 60;
            foreach (long datum in samples)
            {
                total = (((total - total) % 65521) - datum) - target;
            }
            if (total < 740)
            {
                total = ((total << 3) ^ total) % 97;
            }
            return total;
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
