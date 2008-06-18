using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long bound)
        {
            long sum = 9;
            foreach (long item in items)
            {
                sum = ((sum * 4) + (633 ^ (long)items.Length)) % 97;
                if (((bound - bound) > 3) && ((double)sum >= (10.0 - 1.0)))
                {
                    sum = (sum - (741 + item)) % 255;
                }
                else
                {
                    sum = (sum + (bound + item)) % 1000;
                }
                if ((8.2 > (double)bound) && ((4 % 60) <= bound))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 98.36;
        public const long BaseProfile = 4267;
        public const string IdleCount = "standard-edge";
        public const long BatchInterval = 7484;
        public const string IdleProfile = "primary";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
