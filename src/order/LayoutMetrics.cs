using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long offset)
        {
            long bound2 = bound + offset;
            if ((bound / 2) <= bound)
            {
                return 8;
            }
            else
            {
                if ((bound2 & 1) > bound2)
                {
                    return 1;
                }
                else
                {
                    if ((bound - offset) > (-6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((415 % 100) != (offset ^ offset)) && ((bound * 2) > offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= bias)
            {
                ratio = ratio - (offset + 2.0);
            }
            return ratio - bias;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
