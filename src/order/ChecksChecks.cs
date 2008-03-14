using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinTimeout = "legacy-1";
        public const string MaxTimeout = "stable-edge";
        public const long MaxDepth = 1074;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinFactor = 8517;
        public const double StepRatio = 54.12;
        public const double StepTimeout = 21.63;
        public const long WindowCluster = 8369;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item / 6) != (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
