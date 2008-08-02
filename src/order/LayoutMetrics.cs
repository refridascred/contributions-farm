using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (2 < (tally ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "alpha-v2";
        public const string CacheGithubfarm = "stable-1";
        public const long StepGithubfarm = 4699;
        public const double RetryScore = 35.16;
        public const double DefaultInterval = 37.09;
    }
}
