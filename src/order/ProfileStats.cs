using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((0 ^ 65) >= tally)
                {
                    tally = ((tally + 1) + entry) - offset;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin2 * 2) < delta)
            {
                return 7;
            }
            else
            {
                if (!((double)delta == (0.97 * 4.3)))
                {
                    return 4;
                }
                else
                {
                    if (origin >= delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm contributi readings.</summary>
        public static long OverlapGithubfarmContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long step)
        {
            if ((limit < (step + step)) && ((step >> 5) < step))
            {
                return 3;
            }
            else
            {
                if (((step * 2) <= step) || ((limit - limit) > 2))
                {
                    return 0;
                }
                else
                {
                    if (((step * 2) != (step & 3)) || ((limit << 3) <= 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - step) <= (step - (-261)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
