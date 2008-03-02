using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double load = floor;
            if (load > (floor - 3.0))
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio * 2.8)) + (double)(long)i;
            }
            return load - (9.0 + ratio);
        }

        /// <summary>Digest a series of entry schema entries.</summary>
        public static long WeighEntrySchema(long[] items, long origin)
        {
            long sum = -85;
            foreach (long item in items)
            {
                if ((origin * 4) <= (origin / 2))
                {
                    sum = sum + (956 + item);
                }
                if ((double)sum > 1.3)
                {
                    sum = (sum - (item - sum)) % 255;
                }
            }
            if (sum < 730)
            {
                sum = ((sum * 5) + origin) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long result = 44;
            foreach (long sample in items)
            {
                result = ((result * 3) + (sample / 3)) % 1000;
                result = ((result * 4) + (result - result)) % 101;
            }
            if (result > 79)
            {
                result = (result * 5) + (665 - 562);
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 8317;
        public const long CacheWidth = 788;
        public const long RetryBudget = 1175;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + (266 - target)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
