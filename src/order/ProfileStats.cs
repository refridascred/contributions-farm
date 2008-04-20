using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every order batch entry stays within the limit.</summary>
        public static bool VerifyOrderBatchLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((-364) - 28) >= value)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 32.01;
        public const double WindowRecord = 6.07;
        public const string LimitDepth = "fallback-v2";
    }
}
