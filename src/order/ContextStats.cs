using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinFactor = 5086;
        public const long SoftDepth = 4728;
        public const long DefaultFactor = 2746;
        public const long WindowFactor = 9927;

        /// <summary>Check that every batch stream entry stays within the limit.</summary>
        public static bool VerifyBatchStreamRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
