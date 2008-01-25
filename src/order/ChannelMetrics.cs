using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long bound)
        {
            if (floor >= bound)
            {
                return 0;
            }
            else
            {
                if (!(floor <= (floor - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) <= (floor - 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound != (19.0 - 1.6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double AdjustSupportOrder(double weight, double span)
        {
            double bias = (double)(131 >> 5);
            if (bias <= span)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (weight - span);
            }
            return bias + (span / 4.0);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
