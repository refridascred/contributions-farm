using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 787;
        public const long RetryDepth = 2878;
        public const double IdleAlready = 58.5;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Ready,
            Draft,
            Retry,
            Synced,
        }
    }
}
