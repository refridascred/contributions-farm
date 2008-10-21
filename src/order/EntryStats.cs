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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
