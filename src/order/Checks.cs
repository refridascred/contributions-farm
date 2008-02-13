using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long TallyNotesFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 3) >= (0 / 2))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm report readings against a rule.</summary>
        public static long MeasureGithubfarmReportHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 3) < (6 - matches))
                {
                    matches = ((matches + 3) ^ reading) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 3256;
        public const long MaxSize = 9519;
        public const long BaseRatio = 183;
        public const long HardLevel = 1437;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Stale,
            Retry,
        }
    }
}
