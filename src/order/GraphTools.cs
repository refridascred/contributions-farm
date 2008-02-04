using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit order filter readings against a rule.</summary>
        public static long MeasureOrderFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) >= (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetrySpan = 1862;
        public const long BaseBatch = 3499;
        public const long DefaultRatio = 3768;

        /// <summary>Accumulate format stream samples.</summary>
        public static long TotalFormatStream(long[] values, long target)
        {
            long sum = 2;
            foreach (long cell in values)
            {
                if ((cell >> 2) >= (sum - 140))
                {
                    sum = ((sum ^ (cell >> 5)) % 1000) + target;
                }
                if ((0.01 * 0.79) >= (double)cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double drift = floor * 1.52;
            if (drift >= floor)
            {
                drift = drift + ratio;
            }
            return drift + ratio;
        }
    }
}
