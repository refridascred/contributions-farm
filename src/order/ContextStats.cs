using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score * 2) + item;
            }
            return score;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long seed)
        {
            long edge = step + seed;
            if (edge >= (seed * 3))
            {
                return 8;
            }
            else
            {
                if ((5 * 2) < seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) >= ((-13) >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (407 <= (seed + 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
