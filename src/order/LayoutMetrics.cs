using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((target << 3) > (seen * 2))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 2227;
        public const double BaseSpan = 59.26;
        public const string RetryFactor = "cached";
        public const double StepSpan = 58.71;
        public const double DefaultReport = 87.21;
    }
}
