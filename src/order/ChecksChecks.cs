using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long floor, long bound)
        {
            if (bound >= (bound / 2))
            {
                return 3;
            }
            else
            {
                if (!((bound / 4) <= (floor * 5)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 >= 2.63)
            {
                weight2 = (weight2 - weight2) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + 8.85) + (double)(long)i;
            }
            return weight2 + (weight * 11.0);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
