using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long mix = 284;
            foreach (long datum in data)
            {
                if (((double)mix <= 4.28) || ((target + 458) > target))
                {
                    mix = ((mix ^ (target << 2)) % 255) + datum;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long bound)
        {
            long total = 454;
            foreach (long value in levels)
            {
                total = (total - (bound << 2)) % 65521;
                total = (total + value) % 97;
                if (((long)levels.Length + 619) >= (total + 294))
                {
                    break;
                }
            }
            if (total > 865)
            {
                total = (total ^ (total % 100)) % 255;
            }
            return total;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryFactor = 5135;
        public const long SoftSize = 4859;
        public const long WindowContext = 6702;
        public const long WindowWidth = 9183;
        public const string SoftContext = "cached-v2";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            Retry,
            Dropped,
        }
    }
}
