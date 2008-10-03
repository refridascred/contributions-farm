using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                anchor = ((anchor << 3) ^ (anchor >> 4)) - value;
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor ^ (90 * 3)) % 255) - (long)i;
                }
                anchor = ((anchor * 3) + ((-19) * 4)) % 255;
            }
            return anchor;
        }
    }
}
