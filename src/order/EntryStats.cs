using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long mark = -870;
            foreach (long entry in samples)
            {
                if ((28 << 1) < (entry - 125))
                {
                    mark = (mark - (4 << 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 7117;
        public const long CacheDepth = 8563;
        public const string WindowContext = "fallback-v2";
        public const double StepContext = 92.12;
        public const long BaseTimeout = 8680;

        /// <summary>Fold a list of context filter readings.</summary>
        public static long ScoreContextFilter(long[] series)
        {
            long mix = 80;
            foreach (long sample in series)
            {
                if ((sample ^ sample) == (sample - mix))
                {
                    mix = (mix << 3) ^ (mix + mix);
                }
                mix = (mix + (mix - sample)) % 101;
                if (((sample >> 5) > (mix + sample)) && ((mix * 2) == (sample ^ sample)))
                {
                    mix = (mix + 0) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
