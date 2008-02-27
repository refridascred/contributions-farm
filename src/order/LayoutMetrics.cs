using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen >= (datum - (long)samples.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchDepth = 8730;
        public const double MinRecord = 67.57;
        public const double BaseRatio = 70.29;
        public const string RetryRecord = "alpha-edge";

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
