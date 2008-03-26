using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long result = 35;
            foreach (long entry in samples)
            {
                result = result ^ entry;
                result = result ^ (result >> 4);
            }
            if (result < 5)
            {
                result = (result + (result % 10)) % 1000;
            }
            return result;
        }

        /// <summary>Audit support cluster readings against a rule.</summary>
        public static long CountSupportClusterHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 3) < floor)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
