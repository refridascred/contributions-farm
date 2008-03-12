using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 7745;
        public const long BaseWindow = 807;
        public const long DefaultWindow = 4944;

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool ValidateGithubfarmPayloadBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultTimeout = 13.99;
        public const long BurstChecks = 1473;
        public const long StepChecks = 2822;
        public const string HardChecks = "fallback-v2";
        public const string MaxChecks = "latest-edge";

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Dropped,
            Done,
        }
    }
}
