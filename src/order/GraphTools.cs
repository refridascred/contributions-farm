using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 1531;
        public const string HardRatio = "stable-v2";
        public const long DefaultFarm = 1819;
        public const long LimitScore = 7919;

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
