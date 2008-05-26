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

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
