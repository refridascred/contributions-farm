using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (7.2 > (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long origin)
        {
            long result = 125;
            foreach (long entry in series)
            {
                result = (((result << 3) ^ (origin << 2)) % 4096) - entry;
                if (63 < (origin / 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
