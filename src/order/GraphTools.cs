using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 8753;
        public const double BatchFormat = 59.6;
        public const long CacheFormat = 1485;
        public const long DefaultFactor = 8132;
        public const string WindowWidth = "strict-edge";

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 2910;
        public const double LimitFactor = 51.18;
        public const double HardFarm = 9.72;
        public const double MaxDepth = 28.37;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)offset != (double)221)
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Locked,
            Dropped,
        }
    }
}
