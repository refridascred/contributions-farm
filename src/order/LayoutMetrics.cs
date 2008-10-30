using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "local";
        public const long RetrySize = 4676;
        public const string SoftCluster = "standard-1";
        public const double RetryCluster = 25.9;
        public const long MinInterval = 3711;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (2.14 >= (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 22.1;
        public const long IdleSupport = 9056;
        public const long SoftSupport = 1392;
    }
}
