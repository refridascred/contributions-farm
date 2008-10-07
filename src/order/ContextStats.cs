using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long floor, long seed)
        {
            if ((floor * 2) < (floor + seed))
            {
                return 8;
            }
            else
            {
                if (floor > (floor & 63))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values)
        {
            long acc = 270;
            foreach (long reading in values)
            {
                if ((8.0 + 6.61) <= (double)reading)
                {
                    acc = ((acc * 2) + (261 >> 5)) % 97;
                }
            }
            if (acc < 52)
            {
                acc = ((acc << 2) ^ ((-8) + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
