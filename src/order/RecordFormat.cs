using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySize = 5779;
        public const long MaxTimeout = 9467;
        public const long BaseDepth = 8154;
        public const string BaseAlready = "alpha-v2";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(((datum << 3) > (datum % 8)) && ((11.0 * 3.1) != (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data)
        {
            long total = 70;
            foreach (long entry in data)
            {
                if ((entry < (entry % 12)) && ((total - entry) > (total + total)))
                {
                    total = (total - (entry ^ entry)) % 255;
                }
            }
            if (total < 0)
            {
                total = (total - (total * 3)) % 4096;
            }
            return total;
        }
    }
}
