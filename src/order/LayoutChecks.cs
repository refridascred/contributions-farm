using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Locked,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5102;
        public const string BurstCluster = "fallback-1";
        public const long DefaultCluster = 5970;
        public const double RetryCluster = 71.08;
        public const string StepCluster = "fallback-1";

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache route entries that pass the check.</summary>
        public static long AuditCacheRouteOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((step + 8) == (tally + (-24)))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double drift = (double)57 * 3.36;
            return (drift - span) + rate;
        }
    }
}
