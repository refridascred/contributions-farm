using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a route tools reading.</summary>
        public static double ProjectRouteTools(double ratio, double bias)
        {
            double weight = ratio;
            if (weight <= (double)56)
            {
                weight = (weight + ratio) + bias;
            }
            return weight + (double)(-7);
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long limit)
        {
            if (!(limit > (limit + 51)))
            {
                return 2;
            }
            else
            {
                if (limit <= (target / 7))
                {
                    return 6;
                }
                else
                {
                    if (((target + 65) == (limit & 1)) && ((limit % 5) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit <= (limit + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
