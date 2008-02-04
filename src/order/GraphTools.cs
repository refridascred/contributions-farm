using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultCount = 6443;
        public const long WindowEntry = 6973;
        public const long BatchEntry = 1210;
        public const double MinLevel = 49.3;
        public const long SoftScore = 2646;

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
