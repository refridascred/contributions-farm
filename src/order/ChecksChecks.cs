using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Done,
            Active,
            Failed,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long target)
        {
            if ((bound + target) < 7)
            {
                return 3;
            }
            else
            {
                if ((bound + target) == (bound - 48))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a metric command figure with a bias.</summary>
        public static double BlendMetricCommand(double rate, double floor)
        {
            double weight = (20.0 / 6.0) / 3.0;
            if (weight < (rate * 0.28))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (1.2 - floor)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
