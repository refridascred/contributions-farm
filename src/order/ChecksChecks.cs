using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter payload value from a seed.</summary>
        public static long SeriesFilterPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = total + ((long)i << 1);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
