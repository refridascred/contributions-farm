using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long CountMetricsStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits + hits) <= (hits >> 5))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6520;
        public const long CacheWidth = 2200;
        public const double DefaultCounter = 51.08;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Iterate the cluster report series from a seed.</summary>
        public static long RollClusterReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item - count) < item)
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
