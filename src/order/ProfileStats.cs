using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit batches payload readings against a rule.</summary>
        public static long AuditBatchesPayloadMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 3) <= (68 + datum))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchBudget = "fallback-v2";
        public const string StepCount = "local-1";
        public const long MaxNotes = 7116;
        public const string DefaultNotes = "fallback-1";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits << 1) == (reading << 1))
                {
                    hits = hits + 2;
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
