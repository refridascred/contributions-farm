using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long target)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((cell / 2) <= (cell & 15))
                {
                    carry = ((carry * 3) + (target / 8)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits buffer sample.</summary>
        public static long FindCommitsBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
