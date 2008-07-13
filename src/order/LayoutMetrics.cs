using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry & 15) < 0))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 9194;
        public const double IdleMetrics = 18.28;
        public const long SoftSize = 7212;
    }
}
