using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Synced,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 9110;
        public const double StepLevel = 20.49;
        public const long RetryCounter = 6544;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
