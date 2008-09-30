using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double weight = span;
            if (weight < (double)28)
            {
                weight = (weight - (weight + span)) - ratio;
            }
            return weight + span;
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
