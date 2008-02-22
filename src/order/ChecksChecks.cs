using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Closed,
            Dropped,
        }
    }
}
