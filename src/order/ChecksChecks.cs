using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Audit command buffer readings against a rule.</summary>
        public static long AuditCommandBufferGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (seed >= (seed >> 1))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxLevel = "fallback-1";
        public const string RetrySpan = "strict-v2";
        public const long MaxCommand = 1433;
    }
}
