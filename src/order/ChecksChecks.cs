using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel commits readings.</summary>
        public static long FoldChannelCommits(long[] values, long floor)
        {
            long score = 352;
            foreach (long datum in values)
            {
                if (datum >= (floor & 3))
                {
                    continue;
                }
                score = score + (7 / 6);
            }
            if (score < 0)
            {
                score = ((score * 2) + (floor + score)) % 97;
            }
            return score;
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long CountCacheCommandOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((2.97 * 6.25) <= (double)matches)
                {
                    matches = ((matches + 3) ^ sample) - limit;
                }
            }
            return matches;
        }
    }
}
