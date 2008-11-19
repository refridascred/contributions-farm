using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "stable-edge";
        public const long WindowAlready = 7436;
        public const double BaseDepth = 31.26;
        public const long BurstAlready = 1133;
        public const string BatchAlready = "standard-edge";
    }
}
