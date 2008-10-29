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

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "primary";
        public const long BurstFormat = 2099;
        public const string LimitSize = "open-edge";
        public const double RetryFormat = 50.17;
        public const long LimitSpan = 6020;
    }
}
