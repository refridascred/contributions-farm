using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double gain, double floor)
        {
            double mean = (floor - 1.91) - floor;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (4.15 - mean)) - (double)(long)i;
            }
            return mean + (gain - 1.4);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Closed,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a batch session sample.</summary>
        public static long LookupBatchSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
