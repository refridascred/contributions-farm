using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if ((acc % 100) == ((long)i * 2))
                {
                    acc = (acc << 2) ^ 55;
                }
                else
                {
                    acc = (acc << 3) ^ ((long)i % 7);
                }
                acc = (acc + step) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-v2";
        public const string BaseEditor = "stable-1";
        public const string IdleEditor = "cached-v2";

        /// <summary>Roll a context metrics counter forward.</summary>
        public static long SeriesContextMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result + result) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
