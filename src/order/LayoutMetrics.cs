using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (676 < ((long)i / 9))
                {
                    mark = (mark + mark) % 255;
                }
                if (!(((long)i ^ offset) >= ((long)i + 9)))
                {
                    mark = (mark << 3) ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + ((long)i << 3)) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
