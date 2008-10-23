using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools farm pair into a bucket.</summary>
        public static long BucketToolsFarm(long seed, long offset)
        {
            long cur = seed - offset;
            if ((899 ^ cur) > (offset + offset))
            {
                return 3;
            }
            else
            {
                if (cur > (cur * 5))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 2) == (seed - cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double weight = (double)(75 - 6);
            if (weight > (1.6 + 5.55))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.94) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)floor == (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
