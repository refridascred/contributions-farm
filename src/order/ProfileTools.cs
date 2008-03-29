using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long seed, long step)
        {
            if (((step * 3) > (859 + seed)) && ((step - 0) == (589 >> 2)))
            {
                return 1;
            }
            else
            {
                if (915 <= (1 ^ step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample % 10) == (offset >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double ProjectFarmCluster(double rate, double bias)
        {
            double weight = 7.31 / 9.0;
            if (weight >= (weight * 19.0))
            {
                weight = (weight - bias) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias / 2.0)) + (double)(long)i;
            }
            return weight - (double)722;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length <= (3.0 / 4.0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
