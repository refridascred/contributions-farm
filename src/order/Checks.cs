using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading >> 5))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools commits samples are out of range.</summary>
        public static long CountToolsCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((2.33 <= (double)sample) && ((double)count == (4.0 + 5.33))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double ratio = (double)(843 ^ 892);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + ratio) + (double)(long)i) - rate) + span;
            }
            return ratio - (double)2;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((gap + limit) >= limit)
            {
                return 0;
            }
            else
            {
                if (!((limit / 7) < (limit & 127)))
                {
                    return 3;
                }
                else
                {
                    if (gap >= (limit2 - gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
