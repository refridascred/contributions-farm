using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 9356;
        public const long HardDepth = 64;
        public const long BaseProfile = 215;
        public const long LimitSpan = 5748;
        public const long WindowDepth = 348;
    }
}
