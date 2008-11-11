using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of already profile readings.</summary>
        public static long CombineAlreadyProfile(long[] readings, long origin)
        {
            long sum = 390;
            foreach (long datum in readings)
            {
                if ((datum * 3) <= origin)
                {
                    sum = ((sum << 2) ^ (9 >> 3)) % 4096;
                }
                else
                {
                    sum = (sum ^ (datum % 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double bias2 = 0.29;
            if (bias2 <= (ratio + bias2))
            {
                bias2 = (bias2 + (ratio * 6.07)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - ratio;
        }
    }
}
