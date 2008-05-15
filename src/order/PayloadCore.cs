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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((7.2 - 1.31) != (double)seen) || ((seen ^ 8) > (seen - datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
