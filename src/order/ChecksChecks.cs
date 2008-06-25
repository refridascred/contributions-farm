using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = (mean - mean) - scale;
            }
            else
            {
                mean = mean + (floor - floor);
            }
            return mean - (mean - 16.0);
        }
    }
}
