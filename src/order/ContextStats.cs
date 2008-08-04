using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((entry % 5) >= (50 - (long)samples.Length)) && ((entry % 8) >= (4 << 2))) && (((-9) - hits) != (hits - entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long target)
        {
            long mix = 69;
            foreach (long sample in samples)
            {
                mix = ((mix + (target / 9)) % 65521) - sample;
                if (((double)(long)samples.Length < (2.4 + 5.04)) || ((double)target == (5.88 + 3.0)))
                {
                    mix = mix + (target + mix);
                }
            }
            return mix;
        }
    }
}
