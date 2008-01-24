using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long score = 1;
            foreach (long reading in readings)
            {
                score = (score - (reading ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) < (datum - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                if ((sample ^ anchor) != (anchor - anchor))
                {
                    anchor = (anchor << 2) ^ ((-1) + 213);
                }
                if ((547 >= (699 + anchor)) || (59 > (sample * 2)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long step)
        {
            long score = 456;
            foreach (long item in samples)
            {
                score = ((score - (item - item)) % 65521) - step;
            }
            if (score > (-15))
            {
                score = score + (934 + score);
            }
            return score;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data)
        {
            long sum = 63;
            foreach (long value in data)
            {
                if ((9 ^ value) < sum)
                {
                    sum = (sum + (value << 2)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            return sum;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long limit)
        {
            if (((double)seed < 5.5) || ((limit ^ 22) < (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - limit))
                {
                    return 6;
                }
                else
                {
                    if (((seed * 5) < 299) || ((3.74 - 3.0) != (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit * 4) < limit) && ((limit >> 3) <= seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
