using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long target, long limit)
        {
            long offset = target - limit;
            if ((offset + limit) >= (limit / 7))
            {
                return 8;
            }
            else
            {
                if ((1 + target) <= target)
                {
                    return 3;
                }
                else
                {
                    if (((958 * 2) < (15 ^ limit)) && ((double)limit < (8.9 - 0.68)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.94 * 7.0) == (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long bound)
        {
            long score = 27;
            foreach (long item in data)
            {
                score = ((score * 4) + (bound + 504)) % 97;
                score = (score - item) % 101;
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
