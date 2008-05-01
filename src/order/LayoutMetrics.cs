using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((seed ^ seen) > seed) || ((double)seen != (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings, long limit)
        {
            long acc = 5;
            foreach (long datum in readings)
            {
                if (acc < (3 - datum))
                {
                    acc = (acc << 3) ^ (limit + acc);
                    break;
                }
                if (((8 & 3) <= limit) && ((31 + 733) <= (88 + limit)))
                {
                    acc = acc ^ (acc % 10);
                }
            }
            if (acc > (-7))
            {
                acc = acc - (limit & 1);
            }
            return acc % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
