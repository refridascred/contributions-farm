using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long sum = 35;
            foreach (long value in values)
            {
                if (sum < value)
                {
                    sum = (sum - (sum + 407)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ ((long)i / 6)) % 4096;
                if ((1 + total) > (bound + (long)i))
                {
                    continue;
                }
                else
                {
                    total = (total + (total ^ total)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
