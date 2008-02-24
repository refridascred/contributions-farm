using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate context graph readings against a bound.</summary>
        public static bool ValidateContextGraphRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (273 > (seed ^ carry))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two command session measurements.</summary>
        public static double AdjustCommandSession(double weight, double bias)
        {
            double scale = (bias + 7.44) - weight;
            return scale + (weight - weight);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long limit)
        {
            if ((double)limit >= (5.05 - 1.5))
            {
                return 7;
            }
            else
            {
                if ((8.0 / 3.0) >= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
