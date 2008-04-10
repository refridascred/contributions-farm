using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Retry,
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank already window input into a small class.</summary>
        public static long BucketAlreadyWindow(long limit, long offset)
        {
            if ((limit ^ limit) <= (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long score = 61;
            foreach (long reading in data)
            {
                score = (score ^ (score ^ (long)data.Length)) % 1000;
                if (reading <= (reading ^ offset))
                {
                    break;
                }
            }
            return score;
        }
    }
}
