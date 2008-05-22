using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches notes readings against a rule.</summary>
        public static long AuditBatchesNotesMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)origin <= (3.6 - 8.5))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetrySize = "alpha";
        public const long SoftChannel = 6503;
        public const double BurstLevel = 15.5;
        public const long RetryWidth = 1035;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits - hits) < (item << 1)) && !(17.0 > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(value > (bound * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 67;
            foreach (long entry in levels)
            {
                if ((origin + acc) >= origin)
                {
                    acc = ((acc * 2) + (origin - acc)) - entry;
                }
                else
                {
                    acc = acc - origin;
                }
            }
            if (acc < 72)
            {
                acc = (acc * 5) + (origin + origin);
            }
            return acc % 1000;
        }
    }
}
