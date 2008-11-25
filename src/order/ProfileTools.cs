using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSpan = 84;
        public const double RetryGraph = 89.83;
        public const long LimitDepth = 1123;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Synced,
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long mark = 85;
            foreach (long datum in items)
            {
                if ((mark + 806) <= (datum % 2))
                {
                    mark = (mark + (mark / 7)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 2) ^ (bound & 3)) % 1000;
                mix = (mix + (mix >> 3)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((double)seed == (11.0 / 4.0))
                {
                    acc = (acc * 5) + (seed / 8);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
