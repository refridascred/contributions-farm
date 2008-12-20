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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item + seen) > (step % 100)) || !((double)seen < (6.1 * 7.08)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
