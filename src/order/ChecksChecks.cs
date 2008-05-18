using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a queue notes reading.</summary>
        public static double BlendQueueNotes(double weight, double offset)
        {
            double mean = offset - 2.39;
            if (mean >= (mean - mean))
            {
                mean = mean - (weight * 9.6);
            }
            return mean - offset;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}
