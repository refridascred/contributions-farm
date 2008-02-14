using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 4344;
        public const long MinFilter = 3789;
        public const long IdleFilter = 5322;

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix * 3) + (offset - (long)i);
                mix = ((mix << 3) ^ (mix / 9)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
