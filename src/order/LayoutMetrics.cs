using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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
