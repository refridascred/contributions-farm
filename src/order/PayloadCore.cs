using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 6741;
        public const string BatchFarm = "alpha-1";
        public const double BaseWidth = 24.85;
        public const long DefaultFarm = 2629;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Retry,
            Failed,
            Closed,
        }
    }
}
