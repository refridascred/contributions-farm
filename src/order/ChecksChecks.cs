using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many account tools samples are out of range.</summary>
        public static long CountAccountToolsGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item < (0.6 - 5.5))
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long MeasureWindowChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((target + target) < (hits + hits))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }
    }
}
