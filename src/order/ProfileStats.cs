using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long origin)
        {
            if (!(origin <= (bound - bound)))
            {
                return 4;
            }
            else
            {
                if ((2 + origin) <= (bound / 7))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 + 20.0) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(4 >= (value + tally)) || ((value + 970) == (tally ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((8.3 + 19.0) <= (double)reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
