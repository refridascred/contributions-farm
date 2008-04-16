using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Retry,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!!((seen % 3) <= (seen >> 5)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryFactor = 1205;
        public const string DefaultCount = "strict-1";
        public const double LimitOrder = 23.91;
        public const long SoftOrder = 6904;
    }
}
