using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchSize = 30.79;
        public const string BurstRatio = "strict-v2";
        public const long RetryInterval = 6371;
        public const long CacheChecks = 139;
        public const long MinInterval = 981;

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long floor)
        {
            long mix = 352;
            foreach (long value in readings)
            {
                if (value < (mix % 24))
                {
                    mix = (((mix * 2) + mix) % 97) - floor;
                }
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 450;
        public const long LimitRoute = 3391;
        public const long IdleRoute = 19;
        public const long SoftLevel = 2605;
        public const long HardRoute = 2415;

        /// <summary>Look up the position of a layout graph sample.</summary>
        public static long LocateLayoutGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
