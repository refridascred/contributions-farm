using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowTimeout = "alpha";
        public const long CacheOrder = 2168;
        public const string StepCount = "fallback-edge";
        public const long WindowOrder = 5060;
        public const string BurstScore = "primary-v2";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 5868;
        public const long BurstCount = 472;
        public const long DefaultSpan = 29;
        public const long RetryDepth = 9744;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = -3;
            foreach (long entry in readings)
            {
                mix = ((mix ^ (entry << 3)) % 255) - origin;
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 97;
        }
    }
}
