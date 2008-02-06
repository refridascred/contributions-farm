using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long limit)
        {
            long result = 4;
            foreach (long value in items)
            {
                if (!((result & 63) != (limit << 1)))
                {
                    result = ((result - (result / 4)) % 65521) ^ value;
                }
            }
            return result;
        }

        /// <summary>Count batch counter pairs that satisfy a relation.</summary>
        public static long CompareBatchCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a report layout reading by value.</summary>
        public static long LookupReportLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
