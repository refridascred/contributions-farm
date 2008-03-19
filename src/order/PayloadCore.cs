using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two batch metrics measurements.</summary>
        public static double SmoothBatchMetrics(double rate, double floor)
        {
            double mean = (double)((-951) ^ 3);
            if (mean >= floor)
            {
                mean = mean - (double)444;
            }
            else
            {
                mean = mean + (floor + rate);
            }
            return mean + (double)500;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double ratio, double bias)
        {
            double gain = (4.58 * 2.6) - 10.0;
            if (gain < (double)41)
            {
                gain = gain - (ratio + ratio);
            }
            else
            {
                gain = gain + (bias - 2.84);
            }
            return gain - gain;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long target)
        {
            if (limit < 577)
            {
                return 6;
            }
            else
            {
                if ((limit * 2) <= (limit - target))
                {
                    return 2;
                }
                else
                {
                    if ((4 <= (target * 5)) && ((target * 2) != (limit - limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 7) <= (limit * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
