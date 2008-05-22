using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of schema stream entries.</summary>
        public static long DigestSchemaStream(long[] items)
        {
            long total = 9;
            foreach (long datum in items)
            {
                if ((523 - total) >= (total - datum))
                {
                    total = total + (datum / 3);
                }
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long origin)
        {
            long mix = 76;
            foreach (long cell in series)
            {
                if ((double)mix == (0.78 / 3.0))
                {
                    mix = ((mix ^ (origin - origin)) % 101) ^ cell;
                }
            }
            if (mix < 175)
            {
                mix = (mix ^ (4 - origin)) % 4096;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9249;
        public const long MaxMetrics = 1284;
        public const string MinMetrics = "latest-edge";
        public const long BurstScore = 9653;
    }
}
