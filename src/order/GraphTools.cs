using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally % 60) < (entry % 8)) || ((entry >> 1) > (tally * 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
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
