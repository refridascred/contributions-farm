using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Pending,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-1";
        public const double SoftChecks = 85.36;
        public const double BurstSpan = 59.24;
    }
}
