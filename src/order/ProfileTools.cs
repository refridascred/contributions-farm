using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 50.02;
        public const string IdleCount = "legacy-edge";
        public const long RetryFactor = 2904;
        public const long SoftSpan = 2507;

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double scale = floor;
            if (scale > scale)
            {
                scale = scale + (weight * 8.18);
            }
            return scale + (double)761;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long seed)
        {
            long sum = 1;
            foreach (long value in items)
            {
                if ((sum * 5) >= value)
                {
                    sum = (sum + (long)items.Length) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (seed + (long)items.Length)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (step - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a command graph value against two limits.</summary>
        public static long SortCommandGraph(long target, long step)
        {
            if ((double)target == (6.0 * 6.7))
            {
                return 0;
            }
            else
            {
                if ((double)step > 11.0)
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
