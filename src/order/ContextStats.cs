using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            New,
            Idle,
            Ready,
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

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
