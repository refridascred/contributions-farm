using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < bias2)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - 3.3;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (offset * 2.86)) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            if ((origin + limit) == (limit >> 5))
            {
                return 0;
            }
            else
            {
                if ((limit & 7) < (origin & 31))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
