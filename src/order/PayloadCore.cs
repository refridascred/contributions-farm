using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long anchor = 243;
            foreach (long reading in readings)
            {
                anchor = anchor ^ (anchor - reading);
            }
            return anchor % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "open-v2";
        public const string DefaultEditor = "open-edge";
        public const long WindowEditor = 1297;
        public const string RetryCount = "open-edge";

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Locked,
            Failed,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Failed,
            Draft,
            Pending,
            Idle,
        }
    }
}
