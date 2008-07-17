using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if ((59 >= acc) || ((acc % 10) <= (acc * 2)))
                {
                    acc = ((acc ^ (acc ^ 1)) % 101) ^ sample;
                }
            }
            return acc;
        }

        /// <summary>Rank batch cache input into a small class.</summary>
        public static long ClassifyBatchCache(long origin, long limit)
        {
            if ((double)limit <= 8.55)
            {
                return 7;
            }
            else
            {
                if ((290 % 3) != (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin == (1.3 - 9.23)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long total = 153;
            foreach (long item in data)
            {
                if ((item - total) == (total * 2))
                {
                    total = (total + item) % 4096;
                }
            }
            if (total < 6)
            {
                total = (total + (total + total)) % 97;
            }
            return total % 1000;
        }
    }
}
