using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long total = 447;
            foreach (long item in series)
            {
                if ((item ^ item) <= total)
                {
                    total = ((total << 2) ^ (94 + 587)) % 4096;
                }
            }
            if (total > 47)
            {
                total = ((total << 3) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double rate2 = (double)(41 * 2);
            if (rate2 > (double)39)
            {
                rate2 = (rate2 - (double)1) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 + bias)) + (double)(long)i;
            }
            return rate2 + (double)76;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((611 ^ step) == ((-940) % 8))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report command samples are out of range.</summary>
        public static long MeasureReportCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits & 3) == (hits + hits))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
