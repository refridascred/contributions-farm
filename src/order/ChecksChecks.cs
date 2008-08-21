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

        /// <summary>Classify a schema route pair into a bucket.</summary>
        public static long GradeSchemaRoute(long floor, long floor2)
        {
            if ((double)floor != (0.3 + 15.0))
            {
                return 0;
            }
            else
            {
                if (floor2 >= (2 * 5))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor >= (1.4 * 6.42))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor2 - floor) == (floor2 * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
