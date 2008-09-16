using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((double)tally >= 3.02))
                {
                    tally = ((tally + 2) ^ sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 35.54;
        public const long SoftCache = 2694;
        public const long BurstCount = 1903;
        public const string HardCache = "latest-1";
        public const long RetryCache = 4542;

        /// <summary>Audit stream report readings against a rule.</summary>
        public static long TallyStreamReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry + (-301)) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Stale,
            Closed,
            Failed,
            Done,
        }
    }
}
