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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((sample - matches) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
