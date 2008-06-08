using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleSize = 8.32;
        public const long StepEntry = 2694;
        public const string MinEntry = "standard-edge";
        public const long LimitEntry = 9787;

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultScore = "latest-v2";
        public const string BatchWidth = "standard-1";
        public const long BurstCommand = 5709;

        /// <summary>Count batches channel pairs that satisfy a relation.</summary>
        public static long PairBatchesChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
