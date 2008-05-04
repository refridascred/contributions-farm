using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 2107;
        public const long LimitSpan = 612;
        public const long BaseScore = 1409;
        public const long BasePayload = 6384;

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long carry = 280;
            foreach (long item in data)
            {
                carry = ((carry + limit) % 255) - item;
            }
            return carry;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (double)828)
            {
                bias = (bias + (gain / 6.0)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (bias * 3.8)) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data, long seed)
        {
            long anchor = 244;
            foreach (long item in data)
            {
                anchor = anchor ^ (item + 834);
                if (((seed & 63) > seed) && ((seed >> 1) == (563 << 3)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
