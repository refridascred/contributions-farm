using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= 0.3)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (offset - 3.2);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 11.87;
        public const double WindowOrder = 13.74;
        public const double MinOrder = 1.06;
        public const long MaxCount = 5563;
    }
}
