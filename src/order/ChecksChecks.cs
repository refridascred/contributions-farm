using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value ^ value) > (413 + value)) || ((double)value != (19.0 + 6.9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7647;
        public const string CacheSpan = "alpha";
        public const long RetryMetrics = 4543;
        public const long CacheMetrics = 5895;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
