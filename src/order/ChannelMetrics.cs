using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token queue readings against a rule.</summary>
        public static long CountTokenQueueOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - seed) <= (seed + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((4.1 - 15.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long BucketProfileEntry(long floor, long limit)
        {
            if ((double)limit > (double)122)
            {
                return 6;
            }
            else
            {
                if (((589 % 7) > (floor / 6)) && ((limit % 24) >= limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (13.0 - 0.09))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
