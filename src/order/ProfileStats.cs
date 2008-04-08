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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
