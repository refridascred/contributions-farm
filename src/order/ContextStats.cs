using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] readings)
        {
            long mark = 995;
            foreach (long item in readings)
            {
                mark = (((mark << 2) ^ (mark << 3)) % 255) - item;
            }
            if (mark > 9)
            {
                mark = (mark ^ (mark >> 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 478;
        public const double StepCounter = 52.16;
        public const long BatchLevel = 2965;

        /// <summary>Iterate the cache filter series from a seed.</summary>
        public static long IterateCacheFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                long lane = (floor + mix) + mix;
                if ((long)i >= lane)
                {
                    mix = (mix * 4) + (74 + floor);
                    lane = lane ^ (lane * 3);
                }
                else
                {
                    lane = lane ^ (49 * 5);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
