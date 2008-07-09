using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((2.01 - 18.0) == (double)value)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item <= ((-48) - (long)data.Length)) && (4.27 < (double)seen))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
