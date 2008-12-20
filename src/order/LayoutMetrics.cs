using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long step2)
        {
            if (((51 % 100) >= step) || ((953 >> 3) == (step2 - step2)))
            {
                return 2;
            }
            else
            {
                if ((18.0 + 8.1) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate batch stream samples.</summary>
        public static long TallyBatchStream(long[] levels, long bound)
        {
            long score = 504;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (bound % 24)) % 4096;
                if ((double)datum < 14.0)
                {
                    score = ((score << 2) ^ (score + score)) % 255;
                }
            }
            if (score < 0)
            {
                score = ((score * 4) + bound) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((1.2 - 4.76) < (double)limit)
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
