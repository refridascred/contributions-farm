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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + (-484)) <= (count + item))
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
