using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 98.53;
        public const double LimitWidth = 48.82;
        public const string CacheAccount = "fallback-v2";
        public const long IdleRatio = 1392;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first stream graph entry that matches the target.</summary>
        public static long FindStreamGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (((value & 3) < value) && (value <= (222 * 4)))
                {
                    acc = (acc + (acc / 8)) % 101;
                }
            }
            if (acc > 7)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Ready,
            Paused,
            Synced,
            Dropped,
        }
    }
}
