using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const long IdleRecord = 5256;
        public const string HardCount = "alpha-1";
        public const long CacheRecord = 1975;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long mix = 89;
            foreach (long datum in levels)
            {
                if ((double)mix < (3.01 * 0.9))
                {
                    mix = ((mix + (mix % 24)) % 65521) ^ datum;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            return mix;
        }
    }
}
