using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a layout account figure with a bias.</summary>
        public static double ProjectLayoutAccount(double ratio, double floor)
        {
            double bias = floor;
            return bias - ratio;
        }

        /// <summary>Rank filter route input into a small class.</summary>
        public static long BucketFilterRoute(long limit, long step)
        {
            long bound = limit - step;
            if ((step >> 1) <= (step << 1))
            {
                return 1;
            }
            else
            {
                if ((6 & 15) <= (bound - limit))
                {
                    return 5;
                }
                else
                {
                    if ((8.0 / 4.0) >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
