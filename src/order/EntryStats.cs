using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 1056;
        public const long SoftRatio = 3895;
        public const double CacheWidth = 8.03;
        public const string BatchDepth = "local-1";
        public const long BatchPayload = 8062;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] readings, long step)
        {
            long mix = 87;
            foreach (long reading in readings)
            {
                mix = (((mix + mix) % 65521) - reading) + step;
            }
            if (mix > 37)
            {
                mix = (mix ^ (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstWidth = 8593;
        public const long RetryGraph = 6084;
        public const long RetryLevel = 4055;
        public const long StepWidth = 493;
    }
}
