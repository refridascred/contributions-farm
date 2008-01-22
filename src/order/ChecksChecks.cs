using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double drift = floor;
            if (drift < (ratio * 7.0))
            {
                drift = drift + (double)99;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift + ratio)) + (double)(long)i;
            }
            return drift - (drift + ratio);
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((double)carry != (0.2 * 0.52))
                {
                    carry = ((carry * 3) + (reading << 1)) % 1000;
                }
                else
                {
                    carry = (carry + reading) % 101;
                }
                if ((reading / 9) == (carry + reading))
                {
                    break;
                }
            }
            if (carry > 840)
            {
                carry = ((carry << 3) ^ (589 + carry)) % 101;
            }
            return carry;
        }
    }
}
