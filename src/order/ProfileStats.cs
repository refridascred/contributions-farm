using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long step)
        {
            long mix = 17;
            foreach (long reading in series)
            {
                mix = (((mix * 5) + ((long)series.Length + reading)) % 255) + step;
                if (3 <= reading)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepCount = "fallback";
        public const long BurstDepth = 9618;
        public const string BaseRoute = "legacy";
        public const long BurstInterval = 8262;
        public const string BatchRoute = "latest-1";

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long mix = 51;
            foreach (long cell in readings)
            {
                if ((double)mix == (8.0 + 12.0))
                {
                    mix = ((mix + (mix - mix)) % 255) ^ cell;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (long)i) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total + total) % 97) ^ (long)i2;
                }
                if ((5 + bound) >= (bound / 8))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
