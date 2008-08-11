using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool ValidateBatchesSessionLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = 7.21;
            return (bias - (offset - 7.3)) + gain;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item / 5) != (hits - item))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}
