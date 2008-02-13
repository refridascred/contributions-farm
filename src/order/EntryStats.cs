using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (357 > (matches / 8))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long offset)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if (7 < offset)
                {
                    mix = (mix - (item % 10)) % 1000;
                }
                if ((double)mix > (1.4 + 19.0))
                {
                    break;
                }
            }
            if (mix > 387)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long total = 232;
            foreach (long value in series)
            {
                total = (((total - total) % 101) ^ value) - origin;
            }
            return total;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
