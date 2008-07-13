using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - (limit / 4)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the queue route series from a seed.</summary>
        public static long StepQueueRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i > (2.96 * 16.0))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                else
                {
                    result = (result - (241 << 1)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleSize = "latest-edge";
        public const string BurstCount = "cached-1";
        public const long BurstFilter = 5737;
        public const double CacheFilter = 62.03;
        public const double CacheSpan = 43.44;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
