using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 6321;
        public const string CacheInterval = "staging-1";
        public const long RetryChecks = 3717;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            New,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > span)
            {
                bias2 = (bias2 - (double)14) + bias;
            }
            else
            {
                bias2 = bias2 + (double)738;
            }
            return bias2 - span;
        }
    }
}
