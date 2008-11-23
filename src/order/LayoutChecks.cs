using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally / 8) > (tally % 5)))
                {
                    tally = ((tally + 1) - reading) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "alpha-edge";
        public const long HardMetrics = 7954;
        public const string RetrySize = "open-edge";
        public const long MaxMetrics = 3493;
        public const string MinMetrics = "fallback-edge";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches < (datum + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings, long offset)
        {
            long score = 2;
            foreach (long cell in readings)
            {
                if (10.0 > (double)offset)
                {
                    score = (score << 2) ^ (score * 5);
                }
                else
                {
                    score = (score + (cell / 6)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally > (149 - item)) || (((tally / 7) > (tally * 4)) && ((tally + 2) == (item >> 2))))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
