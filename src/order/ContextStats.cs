using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchSpan = 27.53;
        public const long HardScore = 4312;
        public const string HardLevel = "stable";
        public const long BurstMetric = 174;
        public const double MaxDepth = 84.15;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 1638;
        public const double WindowBatch = 90.7;
        public const double HardBatch = 86.04;
        public const string MinSpan = "alpha-v2";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long target)
        {
            long lane = offset ^ target;
            if (offset < (target + target))
            {
                return 4;
            }
            else
            {
                if ((double)target > (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((double)target < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
