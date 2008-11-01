using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (4.8 > (double)floor)
            {
                return 7;
            }
            else
            {
                if (((895 - floor) >= (floor & 1)) || ((0 >> 1) > offset))
                {
                    return 3;
                }
                else
                {
                    if (!((offset ^ floor) < 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (14.0 / 6.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double mean = (double)86 - (6.1 * 20.0);
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean - (mean * 5.1);
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
