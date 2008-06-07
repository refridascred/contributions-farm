using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long sum = 465;
            foreach (long entry in series)
            {
                if ((double)sum < (double)entry)
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum << 3) ^ (entry - (long)series.Length)) % 97;
                }
            }
            if (sum > 569)
            {
                sum = (sum - (sum + 2)) % 101;
            }
            return sum;
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long MeasureFarmStatsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((0.93 < (double)sample) || (((85 - 6) >= (hits * 3)) && ((sample >> 2) != (sample + 574))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long MeasureGithubfarmBatchesMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((8.24 * 2.4) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the support report entries that pass the check.</summary>
        public static long CountSupportReportHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell / 4) < (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
