using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long MeasureGraphChecksHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((12.0 * 8.0) != (double)bound) && ((157 >> 3) > matches))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i <= mark)
                {
                    mark = (mark * 5) + (bound << 1);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
