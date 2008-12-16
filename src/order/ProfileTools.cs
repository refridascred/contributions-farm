using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long delta = offset - seed;
            if ((double)seed > 3.0)
            {
                return 1;
            }
            else
            {
                if (15.0 < (double)delta)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a checks context reading.</summary>
        public static double AdjustChecksContext(double bias, double bias2)
        {
            double rate = bias;
            if (rate >= (bias + bias2))
            {
                rate = rate + bias2;
            }
            else
            {
                rate = rate + (double)76;
            }
            return rate - (5.7 / 2.0);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((1.24 >= (double)sum) && ((double)(long)i > 10.0))
                {
                    sum = (sum - seed) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
