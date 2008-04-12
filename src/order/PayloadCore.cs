using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7938;
        public const string MinSpan = "cached-v2";
        public const string SoftCommits = "fallback-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6889;
        public const long HardTimeout = 1253;
        public const long WindowPayload = 7908;
    }
}
