using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double LimitInterval = 37.13;
        public const double HardAlready = 41.55;
        public const string MaxWidth = "primary-edge";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Check that every githubfarm session entry stays within the limit.</summary>
        public static bool VerifyGithubfarmSessionLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
