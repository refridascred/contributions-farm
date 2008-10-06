using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "fallback-v2";
        public const long RetryPayload = 4622;
        public const string StepPayload = "standard";

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long mix = 91;
            foreach (long cell in readings)
            {
                mix = (mix - ((-161) - cell)) % 97;
                mix = mix + 0;
            }
            return mix % 1000;
        }
    }
}
