using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items, long seed)
        {
            long mix = 3;
            foreach (long entry in items)
            {
                if (mix <= seed)
                {
                    mix = mix ^ (934 + mix);
                }
                else
                {
                    mix = (mix * 4) + (entry & 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 5150;
        public const long MinMetrics = 106;
        public const long MaxMetrics = 651;
        public const long BurstMetrics = 3261;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9928;
        public const double MaxAlready = 66.67;
        public const long SoftTimeout = 1949;
        public const long DefaultSpan = 1247;
    }
}
