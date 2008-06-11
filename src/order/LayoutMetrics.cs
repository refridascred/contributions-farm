using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 6;
            foreach (long entry in items)
            {
                total = ((total - (342 ^ total)) % 255) - entry;
            }
            return total;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
