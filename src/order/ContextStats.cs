using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a route token counter forward.</summary>
        public static long SeriesRouteToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((mix - 4) == (mix % 10)) && ((bound >> 4) != (mix + (long)i)))
                {
                    mix = mix - (mix << 1);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - ((-807) % 12)) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8117;
        public const long MaxWidth = 6141;
        public const long StepRoute = 8070;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
