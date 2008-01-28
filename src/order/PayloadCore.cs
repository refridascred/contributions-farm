using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "local-edge";
        public const long RetryContext = 7306;
        public const long MaxContext = 1065;
        public const double MinTimeout = 40.5;
        public const string StepContext = "fallback";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long state = 550;
            foreach (long sample in samples)
            {
                if (sample > (state + state))
                {
                    state = state - (state ^ 33);
                }
                else
                {
                    state = ((state << 2) ^ (sample % 12)) % 97;
                }
            }
            if (state < 4)
            {
                state = ((state * 5) + state) % 101;
            }
            return state % 97;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
