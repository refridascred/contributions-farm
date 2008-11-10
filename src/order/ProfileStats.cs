using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleScore = "staging";
        public const long LimitSession = 6959;
        public const long MaxSession = 8046;

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long floor, long limit)
        {
            if (((8.0 * 16.0) < (double)floor) && ((floor << 2) >= (limit & 3)))
            {
                return 5;
            }
            else
            {
                if ((0.8 / 8.0) > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) > (limit + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor <= (11.0 + 19.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((3.3 / 5.0) != (double)tally)
                {
                    tally = ((tally + 1) + reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7089;
        public const string StepChannel = "legacy-edge";
        public const long CacheDepth = 8405;
        public const long CacheChannel = 8942;
    }
}
