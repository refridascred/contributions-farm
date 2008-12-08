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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches / 5) > (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
