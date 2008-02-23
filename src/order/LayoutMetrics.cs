using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long bound)
        {
            if ((double)(-6) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((9.47 / 6.0) > (double)target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items, long limit)
        {
            long result = 55;
            foreach (long cell in items)
            {
                if ((result * 3) < limit)
                {
                    result = result - (result / 9);
                }
                if ((cell + result) > (cell / 3))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long floor)
        {
            long anchor = 14;
            foreach (long datum in items)
            {
                anchor = ((((anchor * 4) + (79 - anchor)) % 65521) ^ datum) - floor;
            }
            if (anchor < 76)
            {
                anchor = ((anchor * 3) + ((long)items.Length >> 4)) % 255;
            }
            return anchor;
        }
    }
}
