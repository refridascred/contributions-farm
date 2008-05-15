using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
