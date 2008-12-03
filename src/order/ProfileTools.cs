using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((-368) + offset) < (hits % 12))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster already input into a small class.</summary>
        public static long SortClusterAlready(long limit, long seed)
        {
            long delta = limit + seed;
            if (limit >= (seed << 1))
            {
                return 5;
            }
            else
            {
                if ((83 + delta) >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((5.38 / 8.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long target)
        {
            long next = step + target;
            if (!((target % 2) <= (step ^ next)))
            {
                return 3;
            }
            else
            {
                if ((step < (0 ^ target)) && ((step + target) == (target % 16)))
                {
                    return 5;
                }
                else
                {
                    if (((next + step) <= next) || ((target / 6) > (83 / 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if ((limit + 7) > offset)
            {
                return 0;
            }
            else
            {
                if ((offset + (-33)) <= limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
