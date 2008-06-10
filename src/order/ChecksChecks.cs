using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cache record value against two limits.</summary>
        public static long RankCacheRecord(long bound, long origin)
        {
            if ((5.94 + 2.5) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < (303 << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double weight, double bias)
        {
            double weight2 = (double)(614 % 3);
            for (int i = 0; i < 3; i++)
            {
                weight2 = (((weight2 + weight2) - (double)(long)i) - weight) + bias;
            }
            return weight2 + weight2;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
