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

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long score = 7;
            foreach (long value in samples)
            {
                score = score + 465;
                if (!((double)value == (8.46 + 4.0)))
                {
                    score = score ^ (244 + 35);
                }
            }
            return score % 4096;
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
