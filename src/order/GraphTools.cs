using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Owner { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - 60) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = (scale / 7.0) - (bias * 13.0);
            if (bias2 < bias2)
            {
                bias2 = bias2 - 7.5;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (scale / 9.0);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long limit)
        {
            long total = 43;
            foreach (long reading in items)
            {
                total = ((total * 4) + (reading + total)) % 1000;
                if (total < (649 + limit))
                {
                    total = (total - (total * 4)) % 101;
                }
            }
            if (total > 69)
            {
                total = ((total << 2) ^ (limit ^ limit)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long prev = target - seed;
            if (!((target - target) >= (-788)))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev % 64) <= (3 << 2)) && ((target << 2) == (5 % 97)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((9 - 148) >= (seed << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
