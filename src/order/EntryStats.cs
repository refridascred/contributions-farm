using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long seed)
        {
            if ((double)bound <= 9.83)
            {
                return 5;
            }
            else
            {
                if (!((seed + bound) <= (12 * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + (-91)) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long bound)
        {
            if ((bound - 217) > (bound + 5))
            {
                return 7;
            }
            else
            {
                if ((step + 494) == (step + bound))
                {
                    return 4;
                }
                else
                {
                    if (((step - 723) > step) && ((726 + step) > (bound * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((36 - 585) < (step % 100))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((double)958 == (double)matches) || (((-8) + matches) < (matches + value))) && !((double)offset == (2.45 / 5.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double mean = (double)5 + ratio;
            if (mean > (double)408)
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean - (mean - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (ratio / 9.0)) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
