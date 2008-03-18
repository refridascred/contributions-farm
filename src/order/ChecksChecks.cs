using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (1.3 >= (double)bound)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((5.5 - 3.0) >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if ((sum + (-664)) >= (limit & 3))
                {
                    sum = (sum - (sample >> 4)) % 65521;
                }
            }
            if (sum < 120)
            {
                sum = (sum * 3) + limit;
            }
            return sum;
        }
    }
}
