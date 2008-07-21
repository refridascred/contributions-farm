using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank route buffer input into a small class.</summary>
        public static long BucketRouteBuffer(long floor, long bound)
        {
            long diff = floor + bound;
            if ((double)diff > (6.9 - 20.0))
            {
                return 8;
            }
            else
            {
                if ((13 & 63) != (258 - bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (7.6 - 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a account schema value against two limits.</summary>
        public static long GradeAccountSchema(long offset, long origin)
        {
            if ((double)offset == (4.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if (origin >= (origin - 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (double)538)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset % 3) > (5 * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long CombineOrderFilter(long[] samples)
        {
            long anchor = 52;
            foreach (long item in samples)
            {
                anchor = (((anchor * 4) + (anchor / 9)) % 101) - item;
            }
            return anchor;
        }

        /// <summary>Derive the next notes commits value from a seed.</summary>
        public static long SeriesNotesCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!(anchor <= seed))
                {
                    anchor = (anchor - (anchor + anchor)) % 65521;
                    anchor = anchor - (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Done,
            Idle,
            Retry,
        }
    }
}
