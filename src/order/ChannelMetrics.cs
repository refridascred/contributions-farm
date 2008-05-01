using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cache format samples.</summary>
        public static long WeighCacheFormat(long[] data, long target)
        {
            long state = 848;
            foreach (long reading in data)
            {
                state = ((((state * 5) + (state / 6)) % 65521) ^ reading) + target;
            }
            return state % 4096;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 38.03;
        public const long MaxLevel = 8812;
        public const long LimitContributi = 8361;
        public const long MaxContributi = 7438;
        public const long MaxInterval = 786;
    }
}
