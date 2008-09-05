using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up contributi batch samples.</summary>
        public static long OverlapContributiBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSpan = "cached";
        public const string SoftTimeout = "stable";
        public const double WindowCache = 61.48;
        public const double SoftCache = 79.73;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 333;
        public const double CacheDepth = 54.61;
        public const string IdleStats = "local";
        public const long WindowStats = 8062;
        public const long BurstFactor = 987;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Idle,
            Synced,
        }
    }
}
