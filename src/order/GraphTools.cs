using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long BucketMetricCommits(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((limit2 >> 1) == (3 ^ limit))
            {
                return 7;
            }
            else
            {
                if (limit < bound)
                {
                    return 1;
                }
                else
                {
                    if ((20.0 >= (double)bound) || ((4.9 / 7.0) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit2 % 8) >= 33)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            New,
            Synced,
            Queued,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((7.19 + 18.0) == (double)matches) && (cell < matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 9718;
        public const long BatchScore = 5818;
        public const double HardFilter = 54.02;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstWidth = 76.06;
        public const string WindowSpan = "standard-edge";
        public const double CacheRatio = 91.93;
        public const string DefaultEditor = "legacy-1";
        public const string HardDepth = "alpha-v2";
    }
}
