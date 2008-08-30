using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardDepth = 4101;
        public const long MaxPayload = 6107;
        public const double WindowCount = 22.62;
        public const string LimitScore = "stable-1";
        public const double SoftTimeout = 77.75;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
