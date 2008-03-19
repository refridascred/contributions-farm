using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches > (394 - matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long DeriveContributiEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a contributi channel value against two limits.</summary>
        public static long GradeContributiChannel(long limit, long floor)
        {
            long bound = limit + floor;
            if (bound <= floor)
            {
                return 4;
            }
            else
            {
                if ((bound / 2) != (5 + bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a command counter pair into a bucket.</summary>
        public static long BucketCommandCounter(long floor, long origin)
        {
            if ((origin <= (origin >> 1)) || ((5 - floor) >= origin))
            {
                return 5;
            }
            else
            {
                if ((double)floor > 5.6)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
