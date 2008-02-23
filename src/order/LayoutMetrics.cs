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

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data)
        {
            long sum = 167;
            foreach (long reading in data)
            {
                if ((double)sum <= (double)77)
                {
                    sum = (sum + (reading % 97)) % 255;
                }
            }
            return sum;
        }
    }
}
