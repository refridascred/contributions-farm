using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (double)(9 + 55);
            if (bias > bias)
            {
                bias = ((bias + (6.91 / 2.0)) - weight) + offset;
            }
            return bias - 0.1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long target)
        {
            long total = 44;
            foreach (long entry in readings)
            {
                total = total ^ entry;
                if (!(target > (95 >> 4)))
                {
                    total = ((total << 3) ^ (target + target)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (entry - target)) % 97;
                }
            }
            if (total > 380)
            {
                total = total ^ target;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftBudget = 919;
        public const long SoftRatio = 3219;
        public const long LimitSpan = 196;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ (long)i) % 1000;
                if (!!(state >= ((long)i * 4)))
                {
                    state = (state << 3) ^ ((long)i >> 2);
                    state = ((state << 2) ^ (offset + offset)) % 4096;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
