using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command session samples.</summary>
        public static long TotalCommandSession(long[] series, long origin)
        {
            long sum = 871;
            foreach (long datum in series)
            {
                if ((double)sum >= (13.0 * 5.4))
                {
                    sum = ((sum ^ (origin & 255)) % 65521) - datum;
                }
                else
                {
                    sum = (sum ^ (5 & 127)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - count) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
