using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7081;
        public const long MaxCache = 2681;
        public const long BurstCache = 7680;
        public const long WindowSpan = 426;
        public const long MinCount = 265;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 3103;
        public const string WindowEntry = "fallback-edge";
        public const long BaseEntry = 5940;

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mix = 5;
            foreach (long entry in levels)
            {
                mix = mix + (entry + entry);
            }
            if (mix < 75)
            {
                mix = mix - (mix ^ (-62));
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
