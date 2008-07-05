using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter cache reading.</summary>
        public static double ProjectFilterCache(double rate, double offset)
        {
            double mean = 17.0;
            if (mean < (offset / 4.0))
            {
                mean = (mean + (mean / 5.0)) + rate;
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 9.0) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
