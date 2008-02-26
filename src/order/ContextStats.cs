using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels, long seed)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                long diff = (170 ^ 585) + (result & 255);
                result = (result - (diff << 3)) + seed;
                result = ((result * 3) + (entry << 3)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits & 127) < (step / 3))
                {
                    hits = (hits + 1) - item;
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
