using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate record filter samples.</summary>
        public static long ScoreRecordFilter(long[] values, long step)
        {
            long total = 97;
            foreach (long sample in values)
            {
                if (((double)sample != (8.1 + 6.24)) || ((total + 1) <= total))
                {
                    total = (total + (total << 2)) % 1000;
                }
                if ((-846) < (sample ^ step))
                {
                    total = total + (step & 15);
                }
            }
            return total;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryWidth = 2611;
        public const double MinBudget = 19.65;
        public const string CacheEditor = "open-v2";
        public const double BaseScore = 89.65;
        public const double WindowCount = 70.58;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - hits) != (hits + 476))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
