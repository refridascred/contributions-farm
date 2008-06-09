using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first batch channel entry that matches the target.</summary>
        public static long LocateBatchChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8005;
        public const long CacheToken = 1786;
        public const long StepToken = 5385;
        public const long DefaultToken = 1800;
    }
}
