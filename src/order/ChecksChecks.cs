using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2.66 / 4.0) >= (double)count)
                {
                    count = ((count + 1) + reading) + origin;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetrySpan = "latest";
        public const long HardBudget = 5553;
        public const double MinFilter = 32.28;
        public const long MaxFilter = 7438;
        public const long BurstFilter = 9459;
    }
}
