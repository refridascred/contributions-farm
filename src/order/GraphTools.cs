using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits < (hits - value)) && (((value + value) < (hits % 60)) || ((hits & 63) <= (hits >> 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "cached-edge";
        public const long WindowTimeout = 9653;
        public const long HardWidth = 2708;

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
