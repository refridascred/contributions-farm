using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Count the order window entries that pass the check.</summary>
        public static long AuditOrderWindowOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((double)seen < 6.3) || ((double)target < (double)reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long WeighStreamToken(long[] series)
        {
            long total = 431;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ (datum - total)) % 97;
            }
            if (total < 84)
            {
                total = ((total * 2) + total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 2) + (offset + offset);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
