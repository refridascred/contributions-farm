using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate payload queue readings against a bound.</summary>
        public static bool ValidatePayloadQueueLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > 9)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter commits entries.</summary>
        public static long TotalFilterCommits(long[] readings)
        {
            long sum = 78;
            foreach (long value in readings)
            {
                sum = sum - (170 + value);
            }
            if (sum > 154)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }
    }
}
