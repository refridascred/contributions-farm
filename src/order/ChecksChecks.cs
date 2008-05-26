using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((seed * 3) < (long)items.Length)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count % 24) == ((long)data.Length + count)))
                {
                    count = ((count + 1) - item) - bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long sum = 878;
            foreach (long datum in items)
            {
                if (((double)datum > (8.0 * 6.2)) || ((datum + sum) <= (650 ^ 3)))
                {
                    sum = (sum - (datum / 9)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
