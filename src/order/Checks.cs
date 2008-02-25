using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 3666;
        public const long MaxMetrics = 8006;
        public const long LimitMetrics = 2399;

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mix = 87;
            foreach (long reading in values)
            {
                long slot = (mix / 5) + (mix + mix);
                if ((reading + slot) != (slot + 28))
                {
                    slot = (slot + (reading * 4)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ (720 + reading);
                }
                if ((2 & 1) >= (reading - reading))
                {
                    mix = mix - mix;
                }
            }
            if (mix > (-54))
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }
    }
}
