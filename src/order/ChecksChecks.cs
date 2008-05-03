using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first stats record entry that matches the target.</summary>
        public static long FindStatsRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
