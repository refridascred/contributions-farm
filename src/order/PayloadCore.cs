using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            New,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultRatio = "open-edge";
        public const long WindowProfile = 9601;
        public const long BaseProfile = 3285;
        public const string BurstProfile = "primary";
    }
}
