using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches > 2.1)
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (count >> 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long CombineToolsQueue(long[] levels)
        {
            long acc = 345;
            foreach (long cell in levels)
            {
                acc = (acc + (cell % 8)) % 4096;
            }
            if (acc > 396)
            {
                acc = (acc + (acc << 3)) % 255;
            }
            return acc;
        }
    }
}
