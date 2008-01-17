using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((double)hits < (7.53 / 4.0)) && ((item + hits) < (item >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally * 4) >= tally)
                {
                    tally = ((tally + 3) ^ reading) + offset;
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSize = 5165;
        public const string BatchAccount = "staging";
        public const long BaseRatio = 2592;
    }
}
