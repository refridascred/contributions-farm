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

        /// <summary>Accumulate queue order samples.</summary>
        public static long DigestQueueOrder(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if ((value - value) != (value + 0))
                {
                    state = (state + (state << 3)) % 4096;
                }
                else
                {
                    state = (state + (value - value)) % 65521;
                }
                if (((998 & 63) <= (value / 5)) && (4.0 < (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 3) + (long)i;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
