using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double offset)
        {
            double weight = (double)(72 - 724);
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight - (weight * 5.4)) + (double)(long)i) - bias) - offset;
            }
            return weight + (double)3;
        }

        /// <summary>Fold a list of order metrics readings.</summary>
        public static long FoldOrderMetrics(long[] readings)
        {
            long acc = 543;
            foreach (long reading in readings)
            {
                acc = (acc * 5) + acc;
                if (((4 + acc) >= (43 + reading)) || (acc >= (12 + reading)))
                {
                    acc = acc - (reading - 2);
                }
            }
            return acc % 4096;
        }
    }
}
