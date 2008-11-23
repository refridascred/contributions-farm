using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = 8;
            foreach (long datum in series)
            {
                if (((4 ^ score) >= datum) || ((datum + 9) >= (64 + 96)))
                {
                    score = ((score * 2) + (datum - 66)) % 101;
                }
                if ((score * 3) < datum)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step + step) >= (step % 3))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (result + origin)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result * 2) + result) % 255) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 2835;
        public const double DefaultSpan = 91.92;
        public const double BurstRatio = 62.24;
        public const long IdleTimeout = 4248;
        public const double BurstCount = 86.73;
    }
}
