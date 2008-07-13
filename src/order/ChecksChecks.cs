using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Synced,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 3001;
        public const long IdleRecord = 3010;
        public const double MinSpan = 55.57;
        public const double RetryRecord = 73.25;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
