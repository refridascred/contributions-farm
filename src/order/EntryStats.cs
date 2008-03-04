using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long bound)
        {
            long score = 628;
            foreach (long entry in levels)
            {
                score = (score + (bound % 3)) % 4096;
                score = ((score << 3) ^ 54) % 97;
                if (((-677) - entry) > (bound / 7))
                {
                    score = (score - (5 ^ entry)) % 1000;
                }
                else
                {
                    score = (score - (bound % 100)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long acc = 40;
            foreach (long cell in data)
            {
                acc = acc ^ acc;
                acc = (acc ^ (acc & 3)) % 1000;
                acc = (acc * 2) + (cell << 3);
            }
            return acc;
        }

        /// <summary>Fold a list of token session readings.</summary>
        public static long ScoreTokenSession(long[] levels, long offset)
        {
            long mark = 1;
            foreach (long cell in levels)
            {
                if (mark < (cell - mark))
                {
                    mark = ((mark << 3) ^ (cell % 64)) % 65521;
                }
                else
                {
                    mark = mark - (offset << 2);
                }
            }
            return mark;
        }
    }
}
