using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long mix = -9;
            foreach (long item in samples)
            {
                if (item >= (item - floor))
                {
                    mix = mix + (item + 77);
                    mix = ((mix * 3) + (mix + item)) % 4096;
                }
                if (((floor << 2) >= mix) || ((floor ^ mix) == (mix + floor)))
                {
                    mix = (mix + floor) % 97;
                }
                else
                {
                    mix = (mix + (floor - item)) % 97;
                }
            }
            if (mix > 2)
            {
                mix = mix ^ (floor * 5);
            }
            return mix % 4096;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 422;
        public const long BurstTimeout = 1600;
        public const long MaxCounter = 4767;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - 5) >= (floor + floor))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
