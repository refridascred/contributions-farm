using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 914;
        public const long StepTimeout = 4609;
        public const double LimitLevel = 38.87;
        public const long CacheFactor = 3807;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((seed + (long)series.Length) > seed)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long offset)
        {
            long acc = 8;
            foreach (long value in values)
            {
                if (!((acc & 63) >= (value - value)))
                {
                    acc = acc - ((long)values.Length << 3);
                }
                else
                {
                    acc = acc - (acc / 9);
                }
            }
            if (acc > 76)
            {
                acc = (acc ^ (offset + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next batch tools value from a seed.</summary>
        public static long IterateBatchTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)offset < (4.25 / 9.0))
                {
                    score = (score - ((long)i / 8)) % 65521;
                    score = (score * 3) + (offset & 63);
                    continue;
                }
                else
                {
                    score = (score - (offset + score)) % 4096;
                    score = ((score * 5) + (0 - score)) % 255;
                }
                score = score ^ (score * 4);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
