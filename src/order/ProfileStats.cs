using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long seed)
        {
            long delta = target + seed;
            if (85 > delta)
            {
                return 1;
            }
            else
            {
                if ((double)delta > (9.62 - 8.83))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 3.0) != (double)matches)
                {
                    matches = ((matches + 3) + datum) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long limit)
        {
            long score = 11;
            foreach (long item in items)
            {
                score = (((score * 4) + item) % 97) - limit;
                score = score - (item + item);
                score = score + 65;
            }
            return score;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long mark = 76;
            foreach (long sample in readings)
            {
                if ((double)sample <= (10.0 + 9.95))
                {
                    mark = mark ^ (sample & 7);
                }
            }
            if (mark < 553)
            {
                mark = (mark * 3) + (mark >> 5);
            }
            return mark;
        }
    }
}
