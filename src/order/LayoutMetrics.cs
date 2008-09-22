using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitFactor = 7731;
        public const string BurstContributi = "legacy-edge";
        public const double IdleContributi = 89.58;
        public const long RetryContributi = 2424;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally ^ tally) <= reading))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
