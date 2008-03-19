using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long anchor = 71;
            foreach (long datum in samples)
            {
                if ((datum * 4) > (datum & 7))
                {
                    anchor = (anchor - datum) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Dropped,
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchBudget = "staging";
        public const long DefaultGithubfarm = 5816;
        public const string WindowGithubfarm = "primary-1";
        public const double StepGithubfarm = 71.76;
        public const string MinInterval = "stable-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 4317;
        public const long StepChecks = 8856;
        public const string RetrySpan = "open-edge";
        public const string CacheChecks = "open";
    }
}
