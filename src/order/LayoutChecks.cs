using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches - matches) >= matches) || ((bound + reading) < 45))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double rate2 = (double)((-15) - 19);
            if (rate2 < (double)(-3))
            {
                rate2 = rate2 + (rate - rate2);
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + (offset / 3.0);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (double)468)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache entry series from a seed.</summary>
        public static long IterateCacheEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                long count = score;
                if ((count + score) <= (limit ^ count))
                {
                    score = score ^ (limit - limit);
                }
                else
                {
                    score = (score - (limit - score)) % 1000;
                    score = (score - (limit << 1)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(reading >= (offset ^ 306)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long origin)
        {
            long delta = seed - origin;
            if ((1.26 * 2.2) == (double)delta)
            {
                return 7;
            }
            else
            {
                if ((origin << 2) <= (origin + delta))
                {
                    return 3;
                }
                else
                {
                    if (!(origin < (seed + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed - seed) < (seed + seed)) || (7.46 < (double)delta))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
