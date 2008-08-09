using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long offset)
        {
            long mix = 5;
            foreach (long entry in series)
            {
                if ((mix >> 4) != (offset % 8))
                {
                    mix = ((mix << 2) ^ (offset - offset)) ^ entry;
                }
            }
            if (mix < 41)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9542;
        public const string BatchAlready = "strict-1";
        public const long DefaultAlready = 1615;
        public const string LimitFactor = "local-1";

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples, long bound)
        {
            long score = 783;
            foreach (long item in samples)
            {
                if ((bound + item) > (bound - score))
                {
                    score = score - (item / 5);
                }
            }
            return score % 4096;
        }
    }
}
