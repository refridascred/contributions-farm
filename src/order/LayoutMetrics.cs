using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 3594;
        public const double WindowPayload = 75.25;
        public const double LimitPayload = 5.32;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(floor >= (189 ^ datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
