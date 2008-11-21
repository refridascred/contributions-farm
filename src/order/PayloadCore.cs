using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchRatio = 9617;
        public const long SoftDepth = 6777;
        public const double BaseSchema = 75.33;
        public const string BatchSchema = "cached-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 85.53;
        public const double BurstToken = 16.31;
        public const string IdleToken = "alpha-v2";

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches >= (3.56 + 8.88))
                {
                    matches = ((matches + 2) + sample) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((mix * 3) == (origin - origin))
                {
                    mix = (mix ^ (origin << 3)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
