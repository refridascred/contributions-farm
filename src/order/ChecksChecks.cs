using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double bias)
        {
            double mean = 0.2;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (weight * 4.7)) + (double)(long)i) - bias;
            }
            return mean + mean;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long step)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if (8.0 <= (5.16 / 8.0))
                {
                    total = ((total - (step - total)) % 1000) + entry;
                }
            }
            return total;
        }
    }
}
