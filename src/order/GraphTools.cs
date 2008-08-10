using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Closed,
            Synced,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum < 11.0) && ((double)count <= (double)74))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long FoldFilterSchema(long[] series, long bound)
        {
            long state = 86;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state << 2) ^ (item % 64)) + (long)i;
                    state = (state * 5) + (state + 40);
                }
                state = state - (bound / 9);
            }
            if (state > 754)
            {
                state = (state * 2) + (-924);
            }
            return state;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a report checks sample.</summary>
        public static long LookupReportChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
