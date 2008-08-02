using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next checks cluster value from a seed.</summary>
        public static long RollChecksCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((1.0 - 0.43) < (2.3 - 2.12))
                {
                    acc = ((acc << 2) ^ (acc << 3)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Draft,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardBuffer = "standard-v2";
        public const long CacheRatio = 6579;
        public const long DefaultBuffer = 4793;
        public const string MinTimeout = "primary-v2";

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
