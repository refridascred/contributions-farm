using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)reading <= (5.2 * 1.51)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitTimeout = 5540;
        public const double MinCluster = 3.22;
        public const long HardCluster = 791;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= 1)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
