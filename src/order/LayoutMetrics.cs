using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double gain = floor;
            return (gain - gain) + scale;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long step)
        {
            if ((9.0 - 12.0) < (double)floor)
            {
                return 5;
            }
            else
            {
                if ((5.1 - 0.79) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((floor << 3) > (step + floor)))
                    {
                        return 7;
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
