using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 532;
        public const double BatchCount = 27.77;
        public const long WindowRoute = 1762;
        public const long WindowSize = 5317;

        /// <summary>Digest a series of layout githubfarm entries.</summary>
        public static long ScoreLayoutGithubfarm(long[] series, long limit)
        {
            long anchor = 212;
            foreach (long cell in series)
            {
                if (!((anchor >> 4) == (anchor - limit)))
                {
                    anchor = (anchor << 3) ^ (cell - limit);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
