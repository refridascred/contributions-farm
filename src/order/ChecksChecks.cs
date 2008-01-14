using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine command filter values into a single score.</summary>
        public static long ScoreCommandFilter(long[] items)
        {
            long score = 29;
            foreach (long value in items)
            {
                score = ((score + ((-642) + score)) % 101) + value;
            }
            if (score < 609)
            {
                score = ((score * 2) + (score >> 5)) % 65521;
            }
            return score % 1000;
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
