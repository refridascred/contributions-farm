using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long mix = -39;
            foreach (long value in items)
            {
                mix = ((mix * 4) + (seed + value)) % 101;
            }
            if (mix < 58)
            {
                mix = (mix ^ seed) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long seed)
        {
            if (!((offset >> 1) < (offset & 63)))
            {
                return 7;
            }
            else
            {
                if (((seed * 2) > seed) && ((seed * 5) != (95 - 219)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4298;
        public const long BurstSpan = 3683;
        public const double SoftEntry = 48.69;
    }
}
