using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultSize = "latest-1";
        public const long MinInterval = 4551;
        public const long RetryWindow = 679;
        public const string IdleWidth = "stable-1";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 7) < sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
