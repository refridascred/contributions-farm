using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] samples)
        {
            long sum = 554;
            foreach (long datum in samples)
            {
                sum = ((sum + ((long)samples.Length % 24)) % 101) - datum;
            }
            return sum;
        }

        /// <summary>Check that every counter checks entry stays within the limit.</summary>
        public static bool ValidateCounterChecksLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long MeasureMetricsCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - count) != (reading >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
