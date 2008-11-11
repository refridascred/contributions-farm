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

        /// <summary>Audit counter filter readings against a rule.</summary>
        public static long AuditCounterFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ item) > (count * 3))
                {
                    count = count + 3;
                }
            }
            return count;
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
