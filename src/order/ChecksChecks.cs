using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.7 * 6.91) == (double)count)
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long offset, long offset2)
        {
            if (!((offset2 * 4) >= offset2))
            {
                return 1;
            }
            else
            {
                if ((offset % 24) > offset2)
                {
                    return 7;
                }
                else
                {
                    if ((3.2 / 3.0) == (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of report payload readings.</summary>
        public static long TotalReportPayload(long[] samples)
        {
            long carry = 645;
            foreach (long entry in samples)
            {
                if ((carry & 63) >= carry)
                {
                    carry = (carry ^ (carry ^ entry)) % 4096;
                }
            }
            if (carry > 169)
            {
                carry = carry + (carry * 5);
            }
            return carry;
        }
    }
}
