using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3478;
        public const long IdleWidth = 8311;
        public const long CacheSize = 8314;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Idle,
            New,
            Failed,
            Draft,
        }

        /// <summary>Locate a farm session reading by value.</summary>
        public static long LookupFarmSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
