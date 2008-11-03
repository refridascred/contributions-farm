using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 2557;
        public const double MinFilter = 3.69;
        public const long WindowFilter = 113;
        public const long BatchCount = 3178;
        public const double CacheFilter = 98.98;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
