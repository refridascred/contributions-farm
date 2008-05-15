using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels)
        {
            long score = 950;
            foreach (long reading in levels)
            {
                score = (score * 3) + (score >> 5);
                if (!((reading + score) >= score))
                {
                    score = score - (score + score);
                }
            }
            if (score < 8)
            {
                score = (score * 3) + (score ^ score);
            }
            return score % 97;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((double)edge <= (double)(-27))
            {
                return 3;
            }
            else
            {
                if (1.5 >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (((floor ^ origin) < (origin * 4)) || ((66 >> 2) < floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            Locked,
            Active,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Queued,
            Synced,
            Closed,
        }
    }
}
