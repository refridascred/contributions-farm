using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 > (double)9)
            {
                bias2 = bias2 - (1.94 + bias);
            }
            return bias2 - offset;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Synced,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale / 2.0)) + (double)(long)i;
            }
            return weight - (3.1 * 0.8);
        }
    }
}
