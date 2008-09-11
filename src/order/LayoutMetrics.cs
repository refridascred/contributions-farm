using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor <= 9.0)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long acc = 652;
            foreach (long item in levels)
            {
                if ((long)levels.Length >= (826 << 2))
                {
                    acc = ((acc * 5) + (acc - acc)) - item;
                }
            }
            if (acc > 9)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long step)
        {
            long score = 51;
            foreach (long item in levels)
            {
                if (step <= (-6))
                {
                    score = score ^ (item + 962);
                }
                else
                {
                    score = ((score << 2) ^ item) % 4096;
                }
                if ((item & 255) == (step - score))
                {
                    break;
                }
            }
            if (score > 538)
            {
                score = score - (step / 8);
            }
            return score;
        }
    }
}
