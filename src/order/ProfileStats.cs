using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels, long floor)
        {
            long mix = 972;
            foreach (long item in levels)
            {
                mix = (mix + (floor - (long)levels.Length)) + item;
                mix = (mix - floor) % 65521;
                if (floor <= ((long)levels.Length % 16))
                {
                    mix = mix + (mix / 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBudget = 94.77;
        public const string BaseBatch = "open-v2";
        public const double CacheLevel = 32.65;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
