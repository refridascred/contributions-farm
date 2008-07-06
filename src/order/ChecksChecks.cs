using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Draft,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSpan = "strict-1";
        public const long IdleBudget = 6562;
        public const string WindowGithubfarm = "latest";
        public const long MinGithubfarm = 9350;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((datum % 64) <= (datum + datum)) || ((double)datum <= (double)matches)) || ((257 + datum) > (-6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
