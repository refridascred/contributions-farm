using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long seed)
        {
            if ((6.13 + 9.1) < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit % 97) > seed)
                {
                    return 8;
                }
                else
                {
                    if (seed >= (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit < 89)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Synced,
            Queued,
        }
    }
}
