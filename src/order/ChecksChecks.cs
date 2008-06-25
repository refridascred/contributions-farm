using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank metrics batch input into a small class.</summary>
        public static long BucketMetricsBatch(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((double)bound2 >= (1.08 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((134 & 255) <= bound2)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long AuditMetricsGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((9.0 - 0.8) > (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
