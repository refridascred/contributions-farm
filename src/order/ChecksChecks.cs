using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long limit, long limit2)
        {
            if ((limit2 - limit2) < (limit2 * 5))
            {
                return 6;
            }
            else
            {
                if ((limit2 & 15) != (limit2 << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (sum + target);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
