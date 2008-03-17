using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long RankBufferSupport(long seed, long limit)
        {
            if ((limit + limit) > (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((limit % 16) < (seed + 159))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 2) >= (seed << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double bias = (double)(86 + 37);
            if (bias <= floor)
            {
                bias = bias + (double)969;
            }
            return bias + ratio;
        }
    }
}
