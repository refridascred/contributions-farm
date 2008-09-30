using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-3) >= (matches % 97)) && (((double)(long)series.Length == (5.17 * 8.54)) && (item > (step / 8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
